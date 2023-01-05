using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using opendataws.data.Context;
using opendataws.data.Models;
using opendataws.entity.Dto;
using opendataws.entity.ParameterModels;

namespace opendataws.webapi.Controllers
{

    [ApiController]
    [Route("api/[controller]/[action]")]
    public class GikomController : ControllerBase
    {


        [HttpGet]
        [ApiExplorerSettings(IgnoreApi = false)]
        public string CanConnect()
        {

            try
            {
                using (var context = new GikomContext())
                {
                    if (context.Database.CanConnect())
                    {
                        return "connected / bağlandı";
                    }
                    else
                    {
                        return "disconnected / bağlantı sağlanamadı";
                    }
                }
            }
            catch (System.Exception ex)
            {

                return ex.Message;
            }
        }

        [HttpGet]
        public List<KonuDto> KonulariGetir()
        {
            using (var context = new GikomContext())
            {
                return context.IncidentTopics.Select(x => new KonuDto
                {
                    Id = x.Id,
                    Baslik = x.Title,
                }).ToList();
            }
        }

        [HttpGet]
        public List<MahalleDto> MahalleleriGetir()
        {
            using (var context = new GikomContext())
            {
                return context.Mahalles.Select(x => new MahalleDto
                {
                    MahalleId = x.MahalleKey,
                    MahalleBaslik = x.MahalleTitle,
                }).ToList();
            }
        }

        [HttpPost]
        public string BildiriSayisiGetir([FromBody] BildiriParametre bildiriParametre)
        {
            using (var context = new GikomContext())
            {
                return bildiriParametre.BitirmeTipi.ToString() + "TamamlananBasvuruSayisi:" + context.Incidents.Where(x =>
                x.MahalleId == bildiriParametre.MahalleId &&
                x.TopicId == bildiriParametre.KonuId &&
                x.Status == "completed" &&
                x.CompletionType == bildiriParametre.BitirmeTipi.ToString() &&
                x.CreatedAt >= ((DateTimeOffset)bildiriParametre.BaslangicTarih).ToUnixTimeSeconds() &&
                x.CreatedAt <= ((DateTimeOffset)bildiriParametre.BitisTarih).ToUnixTimeSeconds()
                ).ToList().Count().ToString();
            }
        }
        
    }
}