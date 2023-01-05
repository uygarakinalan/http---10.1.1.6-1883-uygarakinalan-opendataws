using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsZabitaDilenci
    {
        public int MiPrinx { get; set; }
        public DateTime? GetirildigiTarih { get; set; }
        public int? AlindigiYer { get; set; }
        public string? Aciklama { get; set; }
        public int? EkipKodu { get; set; }
        public string? MahalleId { get; set; }
        public string? IlceId { get; set; }
        public string? CsbmId { get; set; }
        public string? KayitUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? MiStyle { get; set; }
        public string? Adres { get; set; }
        public string? NotEkle { get; set; }
    }
}
