using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class ViewCbSecim2018
    {
        public int? Mahkod { get; set; }
        public string? Mahad { get; set; }
        public string? MaksIlceAdi { get; set; }
        public int? ToplamSecmenSayisi { get; set; }
        public int? ToplamOyKullanan { get; set; }
        public int? ToplamGecerliOy { get; set; }
        public int? ToplamGecersizOy { get; set; }
        public string? BirinciParti { get; set; }
        public int? BirinciPartiOy { get; set; }
        public string? IkinciPartiAdi { get; set; }
        public int? IkinciPartiOy { get; set; }
        public string? UcuncuPartiAdi { get; set; }
        public int? UcuncuPartiOy { get; set; }
        public decimal? BirinciPartiOran { get; set; }
        public decimal? IkinciPartiOran { get; set; }
        public decimal? UcuncuPartiOran { get; set; }
    }
}
