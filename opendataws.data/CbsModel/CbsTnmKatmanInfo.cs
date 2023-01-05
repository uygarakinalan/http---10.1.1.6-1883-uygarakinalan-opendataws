using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsTnmKatmanInfo
    {
        public int Id { get; set; }
        public string? KatmanAdi { get; set; }
        public string? AlanAdi { get; set; }
        public string? AlanText { get; set; }
        public string? AlanTuru { get; set; }
        public int? Sira { get; set; }
    }
}
