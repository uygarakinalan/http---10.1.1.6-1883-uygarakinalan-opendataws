using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class SecimSonuclari2018
    {
        public int? Mahkod { get; set; }
        public string? IlceAdi { get; set; }
        public string? MahalleAdi { get; set; }
        public string? PartiAdi { get; set; }
        public int? PartiOySayisi { get; set; }
        public decimal? PartiOyOrani { get; set; }
        public string Yil { get; set; } = null!;
        public string Ay { get; set; } = null!;
        public string? MaksMahAdi { get; set; }
        public string? MaksIlceAdi { get; set; }
    }
}
