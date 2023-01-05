using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsItfaiyeEgitimKatilimcilar
    {
        public int KatilimciId { get; set; }
        public string? YasGrubuAdi { get; set; }
        public int? ErkekKatilimciSayisi { get; set; }
        public int? KadinKatilimciSayisi { get; set; }
        public int? ToplamKatilimciSayisi { get; set; }
        public int? UyrukId { get; set; }
        public string? UyrukAdi { get; set; }
        public int? EgitimId { get; set; }
        public int? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? YasGrubuKodu { get; set; }
        public string? EngelDurumu { get; set; }
    }
}
