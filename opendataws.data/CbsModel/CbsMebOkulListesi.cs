using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsMebOkulListesi
    {
        public int OkulId { get; set; }
        public string? IlAdi { get; set; }
        public string? IlceAdi { get; set; }
        public int? IlceKodu { get; set; }
        public string? OkulAdi { get; set; }
        public string? OkulAdresi { get; set; }
        public double? Numara { get; set; }
        public string? Telefon1 { get; set; }
        public string? Telefon2 { get; set; }
        public string? TurAdi { get; set; }
        public int? TurId { get; set; }
        public string? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public string? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public int? Aktif { get; set; }
        public string? OzelKod1 { get; set; }
    }
}
