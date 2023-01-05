using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class NviMahalleEntegrasyon
    {
        public int MiPrinx { get; set; }
        public string? MahalleAdi { get; set; }
        public int? KimlikNo { get; set; }
        public int? IlceKodu { get; set; }
        public string? AktifMi { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? KaydedenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }
        public string? MahalleEskiAd { get; set; }
        public string? MiStyle { get; set; }
        public int? Versiyon { get; set; }
    }
}
