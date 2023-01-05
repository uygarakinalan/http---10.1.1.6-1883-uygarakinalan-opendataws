using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsZabitaGorevTutanak
    {
        public int MiPrinx { get; set; }
        public int? EkipKodu { get; set; }
        public int? KurumId { get; set; }
        public int? KonuId { get; set; }
        public DateTime? TutanakTarihi { get; set; }
        public string? TutanakTuru { get; set; }
        public string? Adres { get; set; }
        public string? FaaliyetSuresi { get; set; }
        public int? IlceKodu { get; set; }
        public int? MahalleKodu { get; set; }
        public string? MiStyle { get; set; }
        public int? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public int? Durum { get; set; }
    }
}
