using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class ViewMuhtarTalep
    {
        public int Id { get; set; }
        public string? EvrakNo { get; set; }
        public DateTime? BasvuruTarihi { get; set; }
        public int? MuhtarId { get; set; }
        public int? MahalleId { get; set; }
        public DateTime? SonuclandirmaTarihi { get; set; }
        public int? MudurlukId { get; set; }
        public string? Konu { get; set; }
        public string? Sonuc { get; set; }
        public string? Notlar { get; set; }
        public string? Talep1 { get; set; }
        public string? Talep2 { get; set; }
        public string? Talep3 { get; set; }
        public string? Talep4 { get; set; }
        public string? Talep5 { get; set; }
        public int? TalepTuru { get; set; }
        public int? TalepDurumu { get; set; }
        public string? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? GuncelleyenUserId { get; set; }
        public string? MiStyle { get; set; }
        public string? TalepDurumuTxt { get; set; }
        public string? AdiSoyadi { get; set; }
        public int? Aktif { get; set; }
        public string? IlceAdi { get; set; }
        public string? MahalleAdi { get; set; }
        public string? SayiNo { get; set; }
        public int? BirimId { get; set; }
        public string? BirimAdi { get; set; }
        public string? Tel1 { get; set; }
        public int? EkleyenTuru { get; set; }
    }
}
