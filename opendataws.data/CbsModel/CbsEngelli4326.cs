using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsEngelli4326
    {
        public int MiPrinx { get; set; }
        public int? Turu { get; set; }
        public string? TuruAdi { get; set; }
        public DateTime? GirisTarihi { get; set; }
        public string? SorunAciklamasi { get; set; }
        public int? Durum { get; set; }
        public string? DurumText { get; set; }
        public string? SonucAciklama { get; set; }
        public DateTime? SonucTarihi { get; set; }
        public string? SonuclandiranPersonel { get; set; }
        public int? Onay { get; set; }
        public string? OnayText { get; set; }
        public string? OnayAciklama { get; set; }
        public DateTime? OnayTarihi { get; set; }
        public string? OnaylayanPersonel { get; set; }
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
        public int? X { get; set; }
        public int? Y { get; set; }
        public double? F1 { get; set; }
    }
}
