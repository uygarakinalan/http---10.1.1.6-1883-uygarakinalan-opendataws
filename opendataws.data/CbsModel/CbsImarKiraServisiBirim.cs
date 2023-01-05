using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsImarKiraServisiBirim
    {
        public double? SiraNo { get; set; }
        public double? SozlesmeId { get; set; }
        public double? TasinmazKodu { get; set; }
        public string? Nitelik { get; set; }
        public string? TasinmazAdi { get; set; }
        public string? Muhattap { get; set; }
        public decimal? YillikKira { get; set; }
        public decimal? AylikKira { get; set; }
        public DateTime? SozlesmeBaslangicTarihi { get; set; }
        public DateTime? SozlesmeBitisTarihi { get; set; }
    }
}
