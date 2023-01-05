using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsEkOkulOgrenciler
    {
        public int OgrenciId { get; set; }
        public string? AdSoyad { get; set; }
        public string? Tc { get; set; }
        public string? Cinsiyet { get; set; }
        public int? EkEgitimOkulId { get; set; }
        public string? OkulAdi { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string? EvAdresi { get; set; }
        public int? Yasi { get; set; }
        public string? Degerlendirme { get; set; }
        public int? IlceKodu { get; set; }
        public string? Ilce { get; set; }
        public int? MahalleKodu { get; set; }
        public string? MahalleAdi { get; set; }
        public string? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public string? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public int? OkulId { get; set; }
        public int? ExcellSiraNo { get; set; }
    }
}
