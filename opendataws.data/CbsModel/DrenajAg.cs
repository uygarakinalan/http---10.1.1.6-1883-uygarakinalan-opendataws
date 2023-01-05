using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class DrenajAg
    {
        public string? Layer { get; set; }
        public int? Elevation { get; set; }
        public int? StreamId { get; set; }
        public int? InFlow { get; set; }
        public int? OutFlow { get; set; }
        public string? DrainArea { get; set; }
        public string? MiStyle { get; set; }
        public int MiPrinx { get; set; }
    }
}
