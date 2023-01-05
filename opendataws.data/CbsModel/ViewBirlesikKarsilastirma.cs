using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class ViewBirlesikKarsilastirma
    {
        public string? Ilce { get; set; }
        public string? Mahalle { get; set; }
        public double? Hayir { get; set; }
        public double? HayirYuzde { get; set; }
        public double? Evet { get; set; }
        public double? EvetYuzde { get; set; }
        public string? EvetHayirDurumu { get; set; }
        public decimal? EvetHayirYuzde { get; set; }
        public double? AkpKasimSayi { get; set; }
        public double? AkpKasimOran { get; set; }
        public string? Kontrol { get; set; }
        public string? Durum { get; set; }
        public double? Fark { get; set; }
        public string? MiStyle { get; set; }
        public int MiPrinx { get; set; }
        public string FarkDurum { get; set; } = null!;
        public decimal? FarkYeni { get; set; }
    }
}
