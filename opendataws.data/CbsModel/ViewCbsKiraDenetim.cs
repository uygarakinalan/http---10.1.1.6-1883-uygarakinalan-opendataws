using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class ViewCbsKiraDenetim
    {
        public int KiraDenetimId { get; set; }
        public int? KiraServisiSiraNo { get; set; }
        public int? DenetimTuru { get; set; }
        public DateTime? DenetimTarihi { get; set; }
        public string? Istekler { get; set; }
        public string? Oneriler { get; set; }
        public int? DenetimBirimId { get; set; }
        public int? BirimId { get; set; }
        public DateTime? BirimTarih { get; set; }
        public int? Expr1 { get; set; }
        public string? Birimler { get; set; }
    }
}
