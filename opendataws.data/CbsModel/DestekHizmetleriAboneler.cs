using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class DestekHizmetleriAboneler
    {
        public int Id { get; set; }
        public int? AboneNo { get; set; }
        public string? AboneAdi { get; set; }
        public string? Enlem { get; set; }
        public string? Boylam { get; set; }
        public string? SinyalTuru { get; set; }
    }
}
