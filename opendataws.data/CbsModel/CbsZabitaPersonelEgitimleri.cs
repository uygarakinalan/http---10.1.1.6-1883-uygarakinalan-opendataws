using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsZabitaPersonelEgitimleri
    {
        public int Id { get; set; }
        public int? PersonelId { get; set; }
        public string? EgitimAdi { get; set; }
        public DateTime? EgitimTarihi { get; set; }
        public DateTime? EgitimBaslangicTarihi { get; set; }
        public DateTime? EgitimBitisTarihi { get; set; }
        public string? EgitimSuresi { get; set; }
        public string? EgitimBasariDurumu { get; set; }
        public DateTime? SertifikaTarihi { get; set; }
        public string? EgitimVerenKurum { get; set; }
        public string? EgitimYeri { get; set; }
        public int? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }
    }
}
