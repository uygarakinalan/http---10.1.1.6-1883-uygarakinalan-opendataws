using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsKulKatmanYetkileri
    {
        public int Id { get; set; }
        public int? KatmanId { get; set; }
        public int? KullaniciId { get; set; }
        public int? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
    }
}
