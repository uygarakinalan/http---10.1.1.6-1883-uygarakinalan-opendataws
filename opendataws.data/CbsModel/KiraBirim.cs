using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class KiraBirim
    {
        public int? SiraNo { get; set; }
        public double? SozlesmeId { get; set; }
        public double? TasinmazKodu { get; set; }
        public string? Nitelik { get; set; }
        public string? TasinmazAdi { get; set; }
        public string? Kiraci { get; set; }
        public decimal? AcikAlan { get; set; }
        public decimal? KapaliAlan { get; set; }
        public decimal? ToplamAlan { get; set; }
    }
}
