using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsBasinBillboard
    {
        public int BasinId { get; set; }
        public string? BillboardNoktalari { get; set; }
        public string? DosyaYolu { get; set; }
        public int? DaireBaskanlik { get; set; }
        public string? IlceAdi { get; set; }
        public int? IlceKodu { get; set; }
        public string? Aciklama { get; set; }
        public int? MahalleKodu { get; set; }
        public string? MiStyle { get; set; }
        public string? Durum { get; set; }
        public int? BillboardTuru { get; set; }
        public int? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
    }
}
