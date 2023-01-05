using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsItfaiyePersonelEgitimTur
    {
        public int Id { get; set; }
        public string? EgitimAdi { get; set; }
        public string? OzelKod { get; set; }
        public int? Tur { get; set; }
        public int? Durum { get; set; }
        public int? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
    }
}
