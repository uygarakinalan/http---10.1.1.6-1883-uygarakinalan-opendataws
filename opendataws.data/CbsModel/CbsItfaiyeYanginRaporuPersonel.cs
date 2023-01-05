using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsItfaiyeYanginRaporuPersonel
    {
        public int Id { get; set; }
        public int? PersonelId { get; set; }
        public int? IhbarId { get; set; }
        public string? Tur { get; set; }
        public int? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
    }
}
