using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsItfaiyeYanginRaporuKazaliArac
    {
        public int Id { get; set; }
        public string? AracPlakasi { get; set; }
        public string? AracSahibi { get; set; }
        public string? AracSurucusu { get; set; }
        public string? Aciklama { get; set; }
        public int? IhbarId { get; set; }
        public int? EngelDurumu { get; set; }
        public int? Uyruk { get; set; }
        public string? UyrukAciklama { get; set; }
        public int? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
    }
}
