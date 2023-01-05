using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class MahalleFaaliyet
    {
        public int Id { get; set; }
        public string? ImalatCinsi { get; set; }
        public string? Birim { get; set; }
        public string? Yil2010 { get; set; }
        public string? Yil2011 { get; set; }
        public string? Yil2012 { get; set; }
        public string? Yil2013 { get; set; }
        public string? Yil2014 { get; set; }
        public string? Yil2015 { get; set; }
        public string? Yil2016 { get; set; }
        public string? Yil2017 { get; set; }
        public string? Yil2018 { get; set; }
        public double? Toplam { get; set; }
        public string? Mahalle { get; set; }
        public double? MahalleId { get; set; }
        public string? Durum { get; set; }
        public int? DurumKodu { get; set; }
    }
}
