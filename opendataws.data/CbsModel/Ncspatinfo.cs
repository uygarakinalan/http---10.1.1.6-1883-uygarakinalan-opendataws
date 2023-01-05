using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class Ncspatinfo
    {
        public string Tablename { get; set; } = null!;
        public string Spattype { get; set; } = null!;
        public string Fcname { get; set; } = null!;
        public string? Fcexp { get; set; }
        public int Fcgeometrytype { get; set; }
        public string Fccolumn { get; set; } = null!;
        public double? Cllx { get; set; }
        public double? Clly { get; set; }
        public double? Curx { get; set; }
        public double? Cury { get; set; }
        public byte[]? Projection { get; set; }
        public byte[]? Props { get; set; }
        public DateTime? Tableage { get; set; }
    }
}
