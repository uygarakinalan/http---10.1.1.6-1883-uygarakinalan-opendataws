using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsBitkiStok
    {
        public int MiPrinx { get; set; }
        public int? FirmaId { get; set; }
        public int? PersonelId { get; set; }
        public int? DosyaKodu { get; set; }
        public DateTime? GelenBitkiTarihi { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? GuncelleyenUserid { get; set; }
        public string? KaydedenUserId { get; set; }
        public int? Durum { get; set; }
        public int? Tur { get; set; }
    }
}
