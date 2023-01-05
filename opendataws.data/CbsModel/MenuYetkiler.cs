using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class MenuYetkiler
    {
        public int YetkiId { get; set; }
        public int? MenuId { get; set; }
        public int? KulId { get; set; }
        public int? YetkiInsert { get; set; }
        public int? YetkiDelete { get; set; }
        public int? YetkiUpdate { get; set; }
        public int? YetkiSelect { get; set; }
        public int? KaydedenUserid { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? GuncelleyenUserid { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
    }
}
