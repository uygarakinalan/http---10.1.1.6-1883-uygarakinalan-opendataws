using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class TuikNufus2020
    {
        public double? SNo { get; set; }
        public double? IlKayitNo { get; set; }
        public double? IlceKayitNo { get; set; }
        public double? BeldeKoyKayitNo { get; set; }
        public double? MahalleKayitNo { get; set; }
        public string? IlAdi { get; set; }
        public string? IlceAdi { get; set; }
        public string? BeldeKoyAdi { get; set; }
        public string? BelediyeAdi { get; set; }
        public string? MahalleAdi { get; set; }
        public string? MahalleninBagliOlduguBelediyeninNiteligi { get; set; }
        public double? Toplam { get; set; }
        public double? Erkek { get; set; }
        public double? Kadin { get; set; }
        public int? Tur { get; set; }
        public string? TurAdi { get; set; }
    }
}
