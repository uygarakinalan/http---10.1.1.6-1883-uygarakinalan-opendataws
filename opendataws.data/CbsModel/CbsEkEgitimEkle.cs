using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsEkEgitimEkle
    {
        public int MiPrinx { get; set; }
        public string? OkulAdi { get; set; }
        public string? EgitimAdi { get; set; }
        public DateTime? EgitimTarihi { get; set; }
        public string? EgitmenAdi { get; set; }
        public string? FaaliyetBilgisi { get; set; }
        public string? IlceKodu { get; set; }
        public string? MahalleKodu { get; set; }
        public string? CaddeSokakKodu { get; set; }
        public string? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public string? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? MiStyle { get; set; }
        public string? OzelKod1 { get; set; }
        public string? Ilce { get; set; }
        public string? Mahalle { get; set; }
        public string? YasGrubuAdi { get; set; }
        public string? YasGrubuKodu { get; set; }
        public string? Degerlendirme { get; set; }
        public string? OgretmenAdi { get; set; }
        public string? Adres { get; set; }
        public int? OkulId { get; set; }
        public int? EgitimeKatilanOgretmenSayisi { get; set; }
        public int? FaaliyetBilgisiId { get; set; }
    }
}
