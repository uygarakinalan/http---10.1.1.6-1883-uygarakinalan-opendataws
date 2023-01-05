using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class ValilikDilenciYetkiliKullanicilar
    {
        public int YetkiId { get; set; }
        public int? KulId { get; set; }
        public int? BirimId { get; set; }
        public int? Durum { get; set; }
        public int? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
    }
}
