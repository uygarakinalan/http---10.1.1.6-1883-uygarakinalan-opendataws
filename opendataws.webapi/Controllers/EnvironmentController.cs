using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using opendataws.data.Context;
using opendataws.entity.Entities;
using opendataws.webapi.Model.FromApi;

namespace opendataws.webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class EnvironmentController : ControllerBase
    {
        [HttpPost]
        public string AddData([FromBody] EnvironmentDto environmentData)
        {
            EnvironmentData environment = new EnvironmentData()
            {
                IstasyonAdi = environmentData.IstasyonAdi,
                IstasyonNo = environmentData.IstasyonNo,
                Sicaklik = environmentData.Sicaklik,
                Basinc = environmentData.Basinc,
                Gaz = environmentData.Gaz,
                Pm10 = environmentData.Pm10,
                Pm25 = environmentData.Pm25
            };
            try
            {
                using (var context = new EnvironmentContext())
                {
                    context.Set<EnvironmentData>().Add(environment);
                    context.SaveChanges();
                    return "success";
                }
            }
            catch (System.Exception ex)
            {

                return ex.Message.ToString();

            }


        }

    }
}