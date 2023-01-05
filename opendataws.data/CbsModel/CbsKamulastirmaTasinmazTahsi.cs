using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsKamulastirmaTasinmazTahsi
    {
        public int MiPrinx { get; set; }
        public string? IlceKodu { get; set; }
        public string? MahalleKodu { get; set; }
        public string? Ilce { get; set; }
        public string? Mahalle { get; set; }
        public string? Ada { get; set; }
        public string? Parsel { get; set; }
        public decimal? Yuzolcum { get; set; }
        public string? TahsisSuresi { get; set; }
        public string? TahsisAlinanEdilenKurum { get; set; }
        public string? TahsisAmaci { get; set; }
        public DateTime? TahsisBaslangicTarihi { get; set; }
        public DateTime? TahsisBitisTarihi { get; set; }
        public DateTime? OnTahsisTarihi { get; set; }
        public DateTime? KesinTahsisTarihi { get; set; }
        public string? TapuZeminId { get; set; }
        public string? TapuAda { get; set; }
        public string? TapuParsel { get; set; }
        public string? TapuParselId { get; set; }
        public string? TapuTapuAlan { get; set; }
        public string? TapuKadastroAlan { get; set; }
        public string? TapuMahalleAd { get; set; }
        public string? TapuMahalleId { get; set; }
        public double? EnlemYLat { get; set; }
        public double? BoylamXLng { get; set; }
        public string? Tur { get; set; }
        public int? TurKodu { get; set; }
        public string? Aciklama { get; set; }
        public string? OzelKod1 { get; set; }
        public int? TahsisNumarasi { get; set; }
        public string? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public string? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? MiStyle { get; set; }
        public string? EskiGeometri { get; set; }
    }
}
