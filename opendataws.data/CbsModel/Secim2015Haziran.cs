using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class Secim2015Haziran
    {
        public int Id { get; set; }
        public string? Ilce { get; set; }
        public string? Mahalle { get; set; }
        public double? GecerliOyX { get; set; }
        public double? AkpHaziranSayi { get; set; }
        public double? AkpHaziranOran { get; set; }
        public double? ChpHaziranSayi { get; set; }
        public double? ChpHaziranOran { get; set; }
        public double? MhpHaziranSayi { get; set; }
        public double? MhpHaziranOran { get; set; }
        public double? HdpHaziranSayi { get; set; }
        public double? HdpHaziranOran { get; set; }
        public string? TuikMahalle { get; set; }
        public double? KayitliSecmenSayisi { get; set; }
        public double? OyKullananSecmenSayisi { get; set; }
        public double? GecerliOySayisi { get; set; }
        public int? MaksKimlikno { get; set; }
    }
}
