using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class SecimIlcePartiSonuc
    {
        public int Id { get; set; }
        public string? IlceAdi { get; set; }
        public string? PartiAdi { get; set; }
        public double? Haziran { get; set; }
        public double? Kasim { get; set; }
        public int? IlceKodu { get; set; }
    }
}
