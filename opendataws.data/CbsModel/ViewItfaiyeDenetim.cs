using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class ViewItfaiyeDenetim
    {
        public int? RaporYil { get; set; }
        public int? RaporAy { get; set; }
        public string? IsyeriTuru { get; set; }
        public string? IsyeriTuruAdi { get; set; }
        public string? IsyeriSahibiAdSoyad { get; set; }
        public string? IsyeriAdi { get; set; }
        public DateTime? DenetimTarihi { get; set; }
        public int MiPrinx { get; set; }
        public decimal? Ucret { get; set; }
        public string? MiStyle { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? GuncelleyenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public string? KaydedenUserId { get; set; }
        public string? IlceKodu { get; set; }
        public string? Ilce { get; set; }
        public string? MahalleKodu { get; set; }
        public string? Mahalle { get; set; }
        public string? DenetimAmiri3Adi { get; set; }
        public string? DenetimAmiri3 { get; set; }
        public string? DenetimAmiri2Adi { get; set; }
        public string? DenetimAmiri2 { get; set; }
        public string? DenetimAmiri1Adi { get; set; }
        public string? DenetimAmiri1 { get; set; }
        public string? UygunlukDurumu { get; set; }
        public string? UygunlukDurumKodu { get; set; }
    }
}
