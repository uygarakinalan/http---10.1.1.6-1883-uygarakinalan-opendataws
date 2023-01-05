using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsImarKiraDenetim
    {
        public int KiraDenetimId { get; set; }
        public int? KiraServisiSiraNo { get; set; }
        public int? DenetimTuru { get; set; }
        public DateTime? DenetimTarihi { get; set; }
        public string? Istekler { get; set; }
        public string? Oneriler { get; set; }
    }
}
