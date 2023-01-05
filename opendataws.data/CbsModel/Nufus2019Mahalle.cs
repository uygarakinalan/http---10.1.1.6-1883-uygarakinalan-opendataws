using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class Nufus2019Mahalle
    {
        public int? MahalleId { get; set; }
        public string? IlAdi { get; set; }
        public string? IlceAdi { get; set; }
        public string? MahalleAdi { get; set; }
        public int? Toplam { get; set; }
        public int? Erkek { get; set; }
        public int? Kadin { get; set; }
        public int MiPrinx { get; set; }
    }
}
