using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class Fenislericalismalari
    {
        public int MiPrinx { get; set; }
        public string? Turu { get; set; }
        public string? SorunAciklama { get; set; }
        public DateTime? GirisTarih { get; set; }
        public string? SonucAciklama { get; set; }
        public DateTime? SonucTarihi { get; set; }
        public string? Ilce { get; set; }
        public string? IlceKodu { get; set; }
        public string? Mahalle { get; set; }
        public string? MahalleKodu { get; set; }
        public string? CaddeSokak { get; set; }
        public string? CaddeSokakKodu { get; set; }
        public string? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public string? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? MiStyle { get; set; }
    }
}
