using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class MulkiyetBagimsizBolum
    {
        public int MiPrinx { get; set; }
        public int Id { get; set; }
        public string? Blok { get; set; }
        public string? Giris { get; set; }
        public string? Kat { get; set; }
        public string? No { get; set; }
        public decimal? ArsaPay { get; set; }
        public decimal? ArsaPayda { get; set; }
        public string? Tip { get; set; }
        public int? AltTasinmazId { get; set; }
        public int? ZeminId { get; set; }
    }
}
