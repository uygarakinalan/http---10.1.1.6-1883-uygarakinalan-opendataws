using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class TemsilciOfisi
    {
        public int Id { get; set; }
        public string? Adi { get; set; }
        public string? Tel1 { get; set; }
        public string? Tel2 { get; set; }
        public string? Adres { get; set; }
        public string? Email { get; set; }
        public string? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? GuncelleyenUserId { get; set; }
        public int? Durum { get; set; }
    }
}
