using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class GisAdresler
    {
        public int AdresId { get; set; }
        public int? IlceId { get; set; }
        public int? MahalleId { get; set; }
        public int? CaddeId { get; set; }
        public int? BinaId { get; set; }
        public string? IlceAdi { get; set; }
        public string? MahalleAdi { get; set; }
        public string? CaddeAdi { get; set; }
        public string? BinaAdi { get; set; }
        public string? SiteAdi { get; set; }
        public string? KapiNo { get; set; }
    }
}
