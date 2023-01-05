using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class ViewItfaiyeMahalleRiskRaporu
    {
        public string? IlceAdi { get; set; }
        public string? MahalleAdi { get; set; }
        public int ToplamIhbar { get; set; }
        public int ToplamMudahaledk { get; set; }
        public int OrtalamaMudahaledk { get; set; }
        public int ToplamUlasmadk { get; set; }
        public int OrtalamaUlasmadk { get; set; }
    }
}
