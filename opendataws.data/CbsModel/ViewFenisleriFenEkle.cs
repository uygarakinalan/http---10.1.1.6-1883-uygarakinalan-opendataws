using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class ViewFenisleriFenEkle
    {
        public int MiPrinx { get; set; }
        public double? Deger { get; set; }
        public string? Aciklama { get; set; }
        public string? IlceKodu { get; set; }
        public string? MahalleKodu { get; set; }
        public string? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public string? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? MiStyle { get; set; }
        public string? MahalleAdi { get; set; }
        public string? IlceAdi { get; set; }
    }
}
