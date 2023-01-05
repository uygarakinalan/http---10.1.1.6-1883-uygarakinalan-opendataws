using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using opendataws.data.CbsModel;
using opendataws.data.Context;
using opendataws.entity.Dto;

namespace opendataws.webapi.Controllers
{

    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CevreController : ControllerBase
    {

        [HttpGet]
        public List<PetrolIstasyonDto> PetrolIstastyonlariGetir()
        {
            using (var context = new gisContext())
            {
                return context.ViewCevrePetrolIstasyonlaris.Select(x => new PetrolIstasyonDto
                {
                    Id = x.Id,
                    IstasyonTuru = x.Istasyonturu,
                    Adres = x.Adres,
                    IlceAdi = x.Ilceadi,
                    IstasyonDurumu = x.IstasyonDurumu

                }).ToList();
            }

        }


        [HttpGet]
        public List<HastaneDto> HastaneGetir()
        {
            using (var context = new gisContext())
            {
                return context.ViewCevreHastaneVerileris.Select(x => new HastaneDto
                {

                    Adi = x.KurumAdi,
                    Ilce = x.IlceAdi,
                    Mahalle = x.MahalleAdi

                }).ToList();
            }
        }


        [HttpGet]
        public List<OkulDto> MebOkulGetir()
        {
            using (var context = new gisContext())
            {
                return context.ViewCevreEgitims.Select(x => new OkulDto
                {


                    Adi = x.EgitimAdi,
                    Ilce = x.IlceAdi,
                    OgrenciSayisi = x.OgrenciSayisi.ToString(),
                    SinifTuru = x.SinifBilgisi

                }).ToList();
            }

        }

        /*[HttpGet]
        public List<KatiAtikDto> KatiAtik()
        {
            using (var context = new gisContext())
            {
                return context.ViewKatiAtikVerileris.Select(x => new KatiAtikDto
                {
                    Adi = x.Toplam.ToString()

                }).ToList();
            }
        }*/


    }
}