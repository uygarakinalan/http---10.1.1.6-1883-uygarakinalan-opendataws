using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsImarKiraTasinmazFlexEx
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
        public string? Fotograf { get; set; }
        public int? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }
    }
}
