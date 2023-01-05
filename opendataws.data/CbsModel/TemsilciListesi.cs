using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class TemsilciListesi
    {
        public int Id { get; set; }
        public int? Sno { get; set; }
        public string? AdiSoyadi { get; set; }
        public string? Tc { get; set; }
        public string? Adi { get; set; }
        public string? Soyadi { get; set; }
        public string? Resim { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string? Cinsiyet { get; set; }
        public string? Tel1 { get; set; }
        public string? Tel2 { get; set; }
        public int? IlceId { get; set; }
        public int? MahalleId { get; set; }
        public int? TemsilOfisiId { get; set; }
        public string? IlceAdi { get; set; }
        public string? MahalleAdi { get; set; }
        public string? Adres { get; set; }
        public string? Email { get; set; }
        public int? CalismaDurumu { get; set; }
        public int? Emekli { get; set; }
        public int? Calisan { get; set; }
        public string? Meslegi { get; set; }
        public int? Sigorta { get; set; }
        public string? Donem { get; set; }
        public int? MedeniDurum { get; set; }
        public string? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? GuncelleyenUserId { get; set; }
        public int? Durum { get; set; }
    }
}
