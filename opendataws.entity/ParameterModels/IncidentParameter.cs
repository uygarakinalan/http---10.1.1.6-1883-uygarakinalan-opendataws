using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace opendataws.entity.ParameterModels
{
    public enum BitirmeTipi
    {
        favorable,
        unfavorable
    }


    public class BildiriParametre
    {
        public int MahalleId { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public BitirmeTipi BitirmeTipi { get; set; }
        public int KonuId { get; set; }
        public DateTime BaslangicTarih { get; set; }
        public DateTime BitisTarih { get; set; }
    }
}