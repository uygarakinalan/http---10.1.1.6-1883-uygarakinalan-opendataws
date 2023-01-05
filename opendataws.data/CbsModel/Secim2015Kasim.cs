using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class Secim2015Kasim
    {
        public int Id { get; set; }
        public string? Ilce { get; set; }
        public string? Mahalle { get; set; }
        public double? AkpKasimSayi { get; set; }
        public double? AkpKasimOran { get; set; }
        public double? ChpKasimSayi { get; set; }
        public double? ChpKasimOran { get; set; }
        public double? MhpKasimSayi { get; set; }
        public double? MhpKasimOran { get; set; }
        public double? HdpKasimSayi { get; set; }
        public double? HdpKasimOran { get; set; }
        public string? TuikMahalle { get; set; }
        public double? KayitliSecmenSayisi { get; set; }
        public double? OyKullananSecmenSayisi { get; set; }
        public double? GecerliOySayisi { get; set; }
        public int? MaksKimlikno { get; set; }
    }
}
