using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class FenisleriFaaliyetler
    {
        public string? IlceAdi { get; set; }
        public string? Ad { get; set; }
        public string? ImalatCinsi { get; set; }
        public string? ImalatYeri { get; set; }
        public double? Miktar { get; set; }
        public string? OlcuBirimi { get; set; }
        public double? Maliyeti { get; set; }
        public int? MahalleId { get; set; }
        public int? IlceKodu { get; set; }
    }
}
