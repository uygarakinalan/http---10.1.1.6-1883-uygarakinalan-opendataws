using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsEkSeminerKatilimcilar
    {
        public int KatilimciId { get; set; }
        public string? AdSoyad { get; set; }
        public string? Tc { get; set; }
        public string? KurumAdi { get; set; }
        public int? KurumId { get; set; }
        public string? Cinsiyet { get; set; }
        public int? MeslekKodu { get; set; }
        public string? Mail { get; set; }
        public int? EkSeminerId { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string? EvAdresi { get; set; }
        public int? Yasi { get; set; }
        public int? IlceKodu { get; set; }
        public int? MahalleKodu { get; set; }
        public string? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public string? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public int? ExcellSiraNo { get; set; }
        public string? MeslekAciklama { get; set; }
    }
}
