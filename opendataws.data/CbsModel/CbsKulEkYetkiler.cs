using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsKulEkYetkiler
    {
        public int KulEkyetkiId { get; set; }
        public int? EkyetkiId { get; set; }
        public int? KulId { get; set; }
        public int? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
    }
}
