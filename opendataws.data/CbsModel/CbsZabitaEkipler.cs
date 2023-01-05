using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsZabitaEkipler
    {
        public int EkipId { get; set; }
        public int? EkipKodu { get; set; }
        public string? FaaliyetKonusu { get; set; }
        public int? Adet { get; set; }
        public DateTime? Tarih { get; set; }
        public string? Adres { get; set; }
        public int? BirimId { get; set; }
        public int? AltBirimId { get; set; }
        public int? KayitUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
    }
}
