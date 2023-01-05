using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using opendataws.data.CbsModel;
using opendataws.entity.Dto;

namespace opendataws.webapi.Controllers
{
    namespace opendataws.webapi.Controllers
    {

        [ApiController]
        [Route("api/[controller]/[action]")]
        public class ItfaiyeController : ControllerBase
        {
            [HttpGet]
            public List<ItfaiyeDenetimDto> ItfaiyeDenetimGetir()
            {
                using (var context = new gisContext())
                {
                    return context.ViewItfaiyeDenetims.Select(x => new ItfaiyeDenetimDto
                    {
                        Ilce = x.Ilce,
                        DenetimTarihi = x.DenetimTarihi,
                        IsyeriTuru = x.IsyeriTuru,

                    }).ToList();

                    //context.ViewItfaiyeDenetims.Where(i => i.DenetimTarihi >).ToList().Count().ToString(); cyear 2014< x

                }

            }

            [HttpGet]
            public List<ItfaiyeEgitimDto> ItfaiyeEgitimGetir()
            {
                using (var context = new gisContext())
                {
                    return context.ViewItfaiyeEgitims.Select(x => new ItfaiyeEgitimDto
                    {
                        Ilce = x.Ilce,
                        EgitimKonusu = x.EgitimKonusu,
                        EgitimTarihi = x.EgitimTarihi,
                        YasGrubu = x.YasGrubuAdi,
                        ErkekKatilimci = x.KatilanErkekSayisi,
                        KadinKatilimci = x.KatilanKadinSayisi,

                    }).ToList();


                }

            }
            

            [HttpGet]
            public List<ItfaiyeIhbarDto> ItfaiyeIhbarGetir()
            {
                using (var context = new gisContext())
                {
                    return context.ViewCbsItfaiyeYanginRaporuOluYaralis.Select(x => new ItfaiyeIhbarDto
                    {
                        
                        YanginTuru = x.Tur,

                    }).ToList();

                }

            }

        }
    }
}