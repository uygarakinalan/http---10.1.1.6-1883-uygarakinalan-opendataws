using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsEkKatilimFormu
    {
        public int Id { get; set; }
        public DateTime? EgitimTarihi { get; set; }
        public string? EgitimVerenAdSoyad { get; set; }
        public string? EgitimAlanAdSoyad { get; set; }
        public string? Tc { get; set; }
        public string? EgitimAlanTelefon { get; set; }
        public string? EgitimAlanCinsiyet { get; set; }
        public int? MeslekKodu { get; set; }
        public string? EgitimYeri { get; set; }
        public string? EgitimKonusu { get; set; }
        public string? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public string? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
    }
}
