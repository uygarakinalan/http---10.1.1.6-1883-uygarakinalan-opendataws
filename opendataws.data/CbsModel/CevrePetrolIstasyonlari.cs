using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CevrePetrolIstasyonlari
    {
        public int Id { get; set; }
        public double? SiraNo { get; set; }
        public double? SiraNo1 { get; set; }
        public double? SiraNo2 { get; set; }
        public string? Kod { get; set; }
        public double? SicilNo { get; set; }
        public string? RuhsatSahibiAdiSoyadi { get; set; }
        public string? Adres { get; set; }
        public int? BasvuruYili { get; set; }
        public string? RuhsatNo { get; set; }
        public DateTime? RuhsatTarihi { get; set; }
        public string? GayriSihhi { get; set; }
        public string? Telefon { get; set; }
        public int? TuruId { get; set; }
        public string IstasyonDurumu { get; set; } = null!;
        public string? Ada { get; set; }
        public string? Parsel { get; set; }
        public string? Pafta { get; set; }
        public string? YapiIzinBelgeDurumu { get; set; }
        public decimal? Alan { get; set; }
        public string? Aciklama { get; set; }
        public string? MiStyle { get; set; }
        public string? IlceKodu { get; set; }
        public string? MahalleKodu { get; set; }
        public int? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
    }
}
