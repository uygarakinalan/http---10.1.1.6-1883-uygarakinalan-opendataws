using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class GaskiFaaliyetler
    {
        public int SiraNo { get; set; }
        public int? IlceKodu { get; set; }
        public string? IlceAdi { get; set; }
        public string? MahaleAdi { get; set; }
        public int? MahalleId { get; set; }
        public string? Tur { get; set; }
        public double? Miktar { get; set; }
        public string? Birim { get; set; }
        public string? OlcuBirimi { get; set; }
    }
}
