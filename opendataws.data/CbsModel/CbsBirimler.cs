using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsBirimler
    {
        public int BirimId { get; set; }
        public string? BirimAdi { get; set; }
        public int? KurumId { get; set; }
        public int? DurumAktif { get; set; }
    }
}
