using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using opendataws.webapi.Model.FromApi;

namespace opendataws.webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class EnerjiTuketimiController : ControllerBase
    {

        private readonly HttpClient httpClient;
        private const string url = "https://api.reengen.com/api/do/";
        public EnerjiTuketimiController()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("XConnectionId", "dbd0dc18-2cda-426d-af58-f532300f48a7");
        }

        [HttpGet]
        public async Task<string> TuketimNoktalariGetir()
        {
            try
            {
                StringContent stringContent = new StringContent("{\"$\":\"GetPointHierarchy\"}", System.Text.Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync(url, stringContent);
                response.EnsureSuccessStatusCode();
                var responseString = await response.Content.ReadAsStringAsync();
                return responseString;
            }
            catch (HttpRequestException ex)
            {
                return ex.Message.ToString();
            }
        }

        [HttpPost]
        public async Task<string> TuketimDegerleriGetir([FromBody] GetData getData)
        {
            try
            {
                StringContent stringContent = new StringContent("{\"$\":\"GetData\",\"properties\":{\"series\":[{\"definition\":\"activeEnergy\",\"variant\":\"import\",\"type\":\"actual\",\"xFunction\":\"sum\",\"unit\":\"kWh\",\"decimalPoints\":2},{\"definition\":\"reactiveEnergy\",\"variant\":\"import\",\"type\":\"actual\",\"xFunction\":\"avg\",\"unit\":\"VArh\",\"decimalPoints\":2}],\"point\":[\"" + getData.point + "\"],\"start\":\"" + getData.baslangicTarihi.ToString("yyyy-MM-ddTHH:mm:ss") + "\",\"end\":\"" + getData.bitisTarihi.ToString("yyyy-MM-ddTHH:mm:ss") + "\",\"break\":{\"type\":\"point\"},\"resolution\":\"day\"}}", System.Text.Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync(url, stringContent);
                response.EnsureSuccessStatusCode();
                var responseString = await response.Content.ReadAsStringAsync();
                return responseString;
            }
            catch (System.Exception ex)
            {
                return ex.Message.ToString();
                throw;
            }
        }
    }
}
