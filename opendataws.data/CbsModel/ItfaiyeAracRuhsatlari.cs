using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class ItfaiyeAracRuhsatlari
    {
        public int Id { get; set; }
        public int? AracId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public string? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? KaydedenUserId { get; set; }
        public DateTime? AracRuhsatTarihi { get; set; }
    }
}
