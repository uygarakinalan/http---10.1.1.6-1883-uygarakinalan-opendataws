using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class ViewUiMobil
    {
        public int MiPrinx { get; set; }
        public string? Konu { get; set; }
        public string? Aciklama { get; set; }
        public string? ResimAdi { get; set; }
        public int? Kategori { get; set; }
        public string? KaydedenUserAdi { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? Altkategori { get; set; }
        public string? KoordinatX { get; set; }
        public string? KoordinatY { get; set; }
        public int? Durum { get; set; }
        public string? KaydedenUserId { get; set; }
        public DateTime? Expr1 { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? GuncelleyenUserId { get; set; }
        public int? Aktif { get; set; }
        public string? AltKategoriAdi { get; set; }
        public string DurumText { get; set; } = null!;
        public string? SonucAciklama { get; set; }
        public string? IlceAdi { get; set; }
        public string? IlceKodu { get; set; }
        public string? Ad { get; set; }
        public string? MahalleKodu { get; set; }
        public string? MiStyle { get; set; }
        public string? AnaKategoriAdi { get; set; }
    }
}
