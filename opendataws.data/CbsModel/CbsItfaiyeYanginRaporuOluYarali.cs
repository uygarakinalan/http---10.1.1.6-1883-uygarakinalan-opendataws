using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsItfaiyeYanginRaporuOluYarali
    {
        public int Id { get; set; }
        public string? AdSoyad { get; set; }
        public string? Cinsiyet { get; set; }
        public string? Yas { get; set; }
        public string? Tc { get; set; }
        public int? EngelDurumu { get; set; }
        public int? Uyruk { get; set; }
        public string? UyrukAciklama { get; set; }
        public string? PersonelHalk { get; set; }
        public int? PersonelId { get; set; }
        public int? IhbarId { get; set; }
        public string? Tur { get; set; }
        public int? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
    }
}
