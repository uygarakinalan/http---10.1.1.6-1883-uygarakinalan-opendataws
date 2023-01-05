using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsAltBirimler
    {
        public int Id { get; set; }
        public string? AltBirimAdi { get; set; }
        public int? BirimId { get; set; }
        public string? OzelKod { get; set; }
        public int? DurumAktif { get; set; }
    }
}
