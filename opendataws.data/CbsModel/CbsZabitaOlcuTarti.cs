using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsZabitaOlcuTarti
    {
        public int MiPrinx { get; set; }
        public int? Turu { get; set; }
        public string? Tc { get; set; }
        public string? Adres { get; set; }
        public DateTime? Tarih { get; set; }
        public string? AdiSoyadi { get; set; }
        public string? Isi { get; set; }
        public string? Telefon { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public int? IlceKodu { get; set; }
        public int? MahalleKodu { get; set; }
        public int? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? MiStyle { get; set; }
    }
}
