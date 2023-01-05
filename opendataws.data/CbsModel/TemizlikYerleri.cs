using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class TemizlikYerleri
    {
        public decimal Oid { get; set; }
        public string? Name { get; set; }
        public string? FolderPath { get; set; }
        public decimal? SymbolId { get; set; }
        public decimal? AltMode { get; set; }
        public decimal? Base { get; set; }
        public string? Snippet { get; set; }
        public string? PopupInfo { get; set; }
        public decimal? HasLabel { get; set; }
        public decimal? LabelId { get; set; }
        public string? MiStyle { get; set; }
        public int MiPrinx { get; set; }
    }
}
