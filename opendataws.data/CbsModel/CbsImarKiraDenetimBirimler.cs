using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsImarKiraDenetimBirimler
    {
        public int DenetimBirimId { get; set; }
        public int? BirimId { get; set; }
        public DateTime? BirimTarih { get; set; }
        public int? KiraDenetimId { get; set; }
    }
}
