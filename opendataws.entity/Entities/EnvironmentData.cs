using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace opendataws.entity.Entities
{
    public class EnvironmentData : BaseEntity
    {
        public int? IstasyonNo { get; set; }
        public string? IstasyonAdi { get; set; }
        public string? Sicaklik { get; set; }
        public string? Basinc { get; set; }
        public string? Nem { get; set; }
        public string? Gaz { get; set; }
        public string? Pm25 { get; set; }
        public string? Pm10 { get; set; }
        public DateTime? KayıtTarihi { get; set; }

    }
}