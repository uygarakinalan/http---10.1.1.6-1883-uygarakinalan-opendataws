using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using opendataws.data.Context;
using opendataws.data.MezarlikModels;
using opendataws.entity.Entities.Views;
using opendataws.entity.ParameterModels;

namespace opendataws.webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]

    public class MezarlikController : ControllerBase
    {
        public MezarlikController()
        {

        }

        [HttpPost]
        public string VefatSayisiGetir([FromBody] MezarlikParameter mezarlikParameter)
        {
            using (var context = new MEZARLIKContext())
            {
                var countKadin = context.TestViews.Where(i => i.C == "Kadın" && mezarlikParameter.TarihBaslangic <= i.OlumTarihi && i.OlumTarihi <= mezarlikParameter.TarihBitis).ToList().Count().ToString();
                var countErkek = context.TestViews.Where(i => i.C == "Erkek" && mezarlikParameter.TarihBaslangic <= i.OlumTarihi && i.OlumTarihi <= mezarlikParameter.TarihBitis).ToList().Count().ToString();

                return "KadınVefatSayisi:" + countKadin + "\n" + "ErkekVefatSayisi:" + countErkek;

            }

        }


    }
}