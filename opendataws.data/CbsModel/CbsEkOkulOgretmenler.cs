using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsEkOkulOgretmenler
    {
        public int OgretmenId { get; set; }
        public string? AdSoyad { get; set; }
        public string? Tc { get; set; }
        public string? Cinsiyet { get; set; }
        public int? EkEgitimOkulId { get; set; }
        public string? OkulAdi { get; set; }
        public int? OkulId { get; set; }
        public string? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public string? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public int? ExcellSiraNo { get; set; }
    }
}
