using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class ViewMahallePasif
    {
        public decimal? Objectid { get; set; }
        public string? Ad { get; set; }
        public int? Kimlikno { get; set; }
        public string? Beldeid { get; set; }
        public string? Olusturmat { get; set; }
        public string? Degistirme { get; set; }
        public string? Tanitimkod { get; set; }
        public string? Gecerlilik { get; set; }
        public decimal? Ihtilafdur { get; set; }
        public string? Ihtilafned { get; set; }
        public double? Olusturan { get; set; }
        public double? Degistiren { get; set; }
        public double? ShapeArea { get; set; }
        public double? ShapeLen { get; set; }
        public string? MiStyle { get; set; }
        public int MiPrinx { get; set; }
        public int? Nufus2014 { get; set; }
        public int? Nufus2015 { get; set; }
        public int? Nufus2016 { get; set; }
        public int? IlceKodu { get; set; }
        public int? Nufus2016Erkek { get; set; }
        public int? Nufus2016Kadin { get; set; }
        public string? IlceAdi { get; set; }
        public string? MahalleEskiAdi { get; set; }
        public string? MahalleEskiGeom { get; set; }
        public DateTime? MeclisKararTarihi { get; set; }
        public string? MeclisKararNo { get; set; }
        public int? KararAlanIlceId { get; set; }
        public int? MahalleDurum { get; set; }
    }
}
