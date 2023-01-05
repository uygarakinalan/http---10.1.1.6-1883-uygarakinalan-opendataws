using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class DestekHizmetleriAboneOlaylar
    {
        public int Id { get; set; }
        public string? Sinyal { get; set; }
        public int? AboneNo { get; set; }
        public string? SinyalTuru { get; set; }
        public string? ZoneAdi { get; set; }
        public DateTime? SinyalTarihi { get; set; }
        public string? Rapor { get; set; }
        public string? Operator { get; set; }
        public int? Receiver { get; set; }
        public int? Line { get; set; }
        public string? ActTime { get; set; }
        public string? ResTime { get; set; }
        public string? Enlem { get; set; }
        public string? Boylam { get; set; }
    }
}
