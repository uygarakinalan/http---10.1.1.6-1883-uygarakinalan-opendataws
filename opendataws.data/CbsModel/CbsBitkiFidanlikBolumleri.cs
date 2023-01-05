using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsBitkiFidanlikBolumleri
    {
        public int FidanlikBolumleriId { get; set; }
        public string? FidanlikBolumleri { get; set; }
        public string? OzelKod1 { get; set; }
        public string? OzelKod2 { get; set; }
        public string? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? GuncelleyenUserId { get; set; }
    }
}
