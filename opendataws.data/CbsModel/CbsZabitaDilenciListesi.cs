using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsZabitaDilenciListesi
    {
        public int DilenciListeId { get; set; }
        public string? TcNo { get; set; }
        public string? AdiSoyadi { get; set; }
        public string? AnneAdi { get; set; }
        public string? BabaAdi { get; set; }
        public string? Cinsiyet { get; set; }
        public string? Uyruk { get; set; }
        public int? ElKonulanMalzemeCinsi { get; set; }
        public int? DogumYili { get; set; }
        public int? Yasi { get; set; }
        public string? CocukMu { get; set; }
        public int? KayitUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public int? DilenciId { get; set; }
    }
}
