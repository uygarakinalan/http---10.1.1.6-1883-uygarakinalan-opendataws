using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CevreEgitim
    {
        public int MiPrinx { get; set; }
        public int? EgitimTuru { get; set; }
        public string? EgitimAdi { get; set; }
        public int? OgrenciSayisi { get; set; }
        public DateTime? EgitimTarihi { get; set; }
        public string? EgitmenAdi { get; set; }
        public int? OkulId { get; set; }
        public int? OkulTurId { get; set; }
        public string? KonuYerBilgisi { get; set; }
        public int? TiyatroBilgisi { get; set; }
        public string? Aciklama { get; set; }
        public string? SinifBilgisi { get; set; }
        public int? EgitimBilgisi { get; set; }
        public string? HediyeAdi { get; set; }
        public int? HediyeMiktari { get; set; }
        public int? IlceKodu { get; set; }
        public int? MahalleKodu { get; set; }
        public int? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? MiStyle { get; set; }
    }
}
