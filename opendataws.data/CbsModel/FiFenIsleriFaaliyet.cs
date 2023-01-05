using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class FiFenIsleriFaaliyet
    {
        public int MiPrinx { get; set; }
        public string? BilgiNotu { get; set; }
        public int? TurKodu { get; set; }
        public string? TurAdi { get; set; }
        public int? Yil { get; set; }
        public DateTime? FaaliyetTarihi { get; set; }
        public string? IlceKodu { get; set; }
        public string? MahalleKodu { get; set; }
        public string? Ilce { get; set; }
        public string? Mahalle { get; set; }
        public string? AlanAdi { get; set; }
        public string? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public string? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? MiStyle { get; set; }
        public string? Sembol { get; set; }
        public double? Alan { get; set; }
        public double? Uzunluk { get; set; }
        public string? CaddeSokak { get; set; }
    }
}
