using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsKamulastirmaMulkiyet
    {
        public int MiPrinx { get; set; }
        public string? Ilce { get; set; }
        public string? Mahalle { get; set; }
        public int? IlceKodu { get; set; }
        public int? MahalleKodu { get; set; }
        public string? Ada { get; set; }
        public string? Parsel { get; set; }
        public int? TapuZeminId { get; set; }
        public string? TapuAda { get; set; }
        public string? TapuParsel { get; set; }
        public string? TapuParselId { get; set; }
        public string? TapuTapuAlan { get; set; }
        public string? TapuKadastroAlan { get; set; }
        public string? TapuMahalleAd { get; set; }
        public string? TapuMahalleId { get; set; }
        public string? TapuIlceAd { get; set; }
        public string? TapuIlceId { get; set; }
        public double? EnlemYLat { get; set; }
        public double? BoylamXLng { get; set; }
        public int? BirimId { get; set; }
        public string? Aciklama { get; set; }
        public int? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? MiStyle { get; set; }
        public int? AktifMi { get; set; }
        public int? MulkSahibiId { get; set; }
        public string? MulkSahibiAdi { get; set; }
        public int? MulkTuru { get; set; }
        public int? YapiSahibiId { get; set; }
        public int? RuhsatDurumu { get; set; }
        public string? KatDurumu { get; set; }
        public int? TesisId { get; set; }
    }
}
