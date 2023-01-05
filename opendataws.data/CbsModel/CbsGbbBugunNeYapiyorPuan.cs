using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsGbbBugunNeYapiyorPuan
    {
        public int PuanId { get; set; }
        public string? Puan { get; set; }
        public string? MacAdress { get; set; }
        public string? IpAdress { get; set; }
        public string? Yorum { get; set; }
        public int? FaaliyetId { get; set; }
        public DateTime? PuanlamaTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
    }
}
