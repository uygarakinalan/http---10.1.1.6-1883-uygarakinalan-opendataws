using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class UlasimKasi
    {
        public int MiPrinx { get; set; }
        public string? Adres { get; set; }
        public string? SonucAciklama { get; set; }
        public int? Adet { get; set; }
        public string? KasisCinsi { get; set; }
        public string? KasisDurumu { get; set; }
        public string? KararDurumu { get; set; }
        public DateTime? KararTarihi { get; set; }
        public int? HangiKurumunYaptigi { get; set; }
        public int? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? GuncelleyenUserId { get; set; }
        public string? MiStyle { get; set; }
        public int? IlceKodu { get; set; }
        public int? MahalleKodu { get; set; }
    }
}
