using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class DestekHizmetleriAnlik
    {
        public int Id { get; set; }
        public int? AboneNo { get; set; }
        public string? Sinyal { get; set; }
        public string? SinyalTuru { get; set; }
        public string? ZoneAdi { get; set; }
        public DateTime? SinyalTarihi { get; set; }
        public string? Enlem { get; set; }
        public string? Boylam { get; set; }
        public string? Durum { get; set; }
    }
}
