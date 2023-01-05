using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class SondajlarImar
    {
        public int? Objectid { get; set; }
        public string? Borehole { get; set; }
        public double? YCoor { get; set; }
        public double? XCoor { get; set; }
        public string? Mevki { get; set; }
        public string? HeightM { get; set; }
        public double? DepthM { get; set; }
        public string? WaterTa { get; set; }
        public string? Lith1 { get; set; }
        public double? Lith1Ds { get; set; }
        public string? Lith2 { get; set; }
        public double? Lith2Ds { get; set; }
        public string? Lith3 { get; set; }
        public string? Lith3Ds { get; set; }
        public string? SonLith { get; set; }
        public double? SonLithD { get; set; }
        public string? MiStyle { get; set; }
        public int MiPrinx { get; set; }
        public int? SonLithId { get; set; }
    }
}
