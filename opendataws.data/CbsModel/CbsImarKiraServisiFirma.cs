using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsImarKiraServisiFirma
    {
        public decimal? SiraNo { get; set; }
        public string? Nitelik { get; set; }
        public string? TasinmazAdi { get; set; }
        public decimal? AcikAlan { get; set; }
        public decimal? KapaliAlan { get; set; }
        public decimal? ToplamAlan { get; set; }
        public int? MahalleId { get; set; }
        public string? MahalleAdi { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? KaydedenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }
        public string? Kiraci { get; set; }
        public string? MiStyle { get; set; }
        public int MiPrinx { get; set; }
        public double? TasinmazKodu { get; set; }
        public double? SozlesmeId { get; set; }
    }
}
