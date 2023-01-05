using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsEkSeminer
    {
        public int SeminerId { get; set; }
        public string? SeminerAdi { get; set; }
        public string? SeminerBilgisi { get; set; }
        public DateTime? BaslamaTarihi { get; set; }
        public DateTime? BitisTarihi { get; set; }
        public string? EgitmenAdi { get; set; }
        public string? Degerlendirme { get; set; }
        public string? IlceKodu { get; set; }
        public string? Ilce { get; set; }
        public string? MahalleKodu { get; set; }
        public string? Mahalle { get; set; }
        public string? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public string? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public int? Durum { get; set; }
        public int? Tur { get; set; }
        public int? KatilimciSayisi { get; set; }
        public string? FaaliyetBilgisi { get; set; }
        public int? FaaliyetBilgisiId { get; set; }
    }
}
