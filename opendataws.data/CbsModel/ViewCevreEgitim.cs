using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class ViewCevreEgitim
    {
        public int MiPrinx { get; set; }
        public int? EgitimTuru { get; set; }
        public string? EgitimAdi { get; set; }
        public int? OgrenciSayisi { get; set; }
        public DateTime? EgitimTarihi { get; set; }
        public string? EgitmenAdi { get; set; }
        public int? OkulId { get; set; }
        public string? KonuYerBilgisi { get; set; }
        public int? TiyatroBilgisi { get; set; }
        public string? Aciklama { get; set; }
        public string? SinifBilgisi { get; set; }
        public int? IlceKodu { get; set; }
        public int? MahalleKodu { get; set; }
        public int? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? MiStyle { get; set; }
        public string? EgitimTurAdi { get; set; }
        public string? IlceAdi { get; set; }
        public string? MahalleAdi { get; set; }
        public string? OkulAdi { get; set; }
        public string TiyatroBilgisiAdi { get; set; } = null!;
        public string EgitimBilgisiAdi { get; set; } = null!;
        public int? EgitimBilgisi { get; set; }
    }
}
