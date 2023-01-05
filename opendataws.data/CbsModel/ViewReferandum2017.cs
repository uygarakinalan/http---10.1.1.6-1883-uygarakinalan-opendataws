using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class ViewReferandum2017
    {
        public string? Ilce { get; set; }
        public string? Mahalle { get; set; }
        public double? SandikNo { get; set; }
        public double? KayitliSecmenSayisi { get; set; }
        public double? KatilanSayisi { get; set; }
        public double? GecerliOy { get; set; }
        public double? GecersizOy { get; set; }
        public double? Hayir { get; set; }
        public double? HayirYuzde { get; set; }
        public double? Evet { get; set; }
        public double? EvetYuzde { get; set; }
        public string EvetHayirDurumu { get; set; } = null!;
        public decimal? EvetHayirYuzde { get; set; }
    }
}
