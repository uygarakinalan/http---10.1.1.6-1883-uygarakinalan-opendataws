using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class SarmerEngelliNoktalari
    {
        public int? Id { get; set; }
        public string? Tc { get; set; }
        public string? Adi { get; set; }
        public string? Mensei { get; set; }
        public string? IlceAdi { get; set; }
        public string? MahalleAdi { get; set; }
        public string? Cadde { get; set; }
        public string? Sokak { get; set; }
        public string? Bina { get; set; }
        public string? Kapi { get; set; }
        public string? Daire { get; set; }
        public string? Tel1 { get; set; }
        public string EngelliTc { get; set; } = null!;
        public string? EngelliAdi { get; set; }
        public int GocYili { get; set; }
        public string? GocYeri { get; set; }
        public string? Aciklama { get; set; }
        public string? KonumLat { get; set; }
        public string? KonumLong { get; set; }
        public int MiPrinx { get; set; }
        public string? MiStyle { get; set; }
    }
}
