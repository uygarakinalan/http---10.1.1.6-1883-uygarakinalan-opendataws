using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsZabitaGorevTutanakPersonelleri
    {
        public int Id { get; set; }
        public int? PersonelId { get; set; }
        public int? GorevTutanakId { get; set; }
        public int? KaydedenUserid { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? GuncelleyenUserid { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
    }
}
