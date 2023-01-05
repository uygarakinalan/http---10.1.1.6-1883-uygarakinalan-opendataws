using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class ViewFenIsleriFaaliyet
    {
        public string? KaplamaTuru { get; set; }
        public double? IlceKodu { get; set; }
        public string? IlceAdi { get; set; }
        public double? Kimlikno { get; set; }
        public string? Ad { get; set; }
        public int? Yili { get; set; }
        public string? Alan { get; set; }
        public string? MiStyle { get; set; }
        public int MiPrinx { get; set; }
        public string? Uzunluk { get; set; }
        public string Tur { get; set; } = null!;
        public string? CaddeSokak { get; set; }
        public string Birim { get; set; } = null!;
    }
}
