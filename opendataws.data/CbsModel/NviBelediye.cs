using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class NviBelediye
    {
        public int? Objectid { get; set; }
        public string? Id { get; set; }
        public string? Ad { get; set; }
        public int? Kimlikno { get; set; }
        public int? Tip { get; set; }
        public string? Baglibeledediyeid { get; set; }
        public string? Bucakid { get; set; }
        public string? Ilceid { get; set; }
        public string? Globalid { get; set; }
        public DateTime? Olusturmatarihi { get; set; }
        public DateTime? Degistirmetarihi { get; set; }
        public DateTime? Gecerliliktarihi { get; set; }
        public int? Ihtilafdurumu { get; set; }
        public string? Ihtilafnedeni { get; set; }
        public string? Kuruluskararsayisi { get; set; }
        public DateTime? Kuruluskarartarihi { get; set; }
        public string? Yetkiliidarekodu { get; set; }
        public double? Olusturan { get; set; }
        public double? Degistiren { get; set; }
        public int? Operationnumber { get; set; }
        public string? Operationdescription { get; set; }
        public string? Beldeid { get; set; }
        public string? Ilid { get; set; }
        public int? Verikaynagi { get; set; }
        public double? ShapeLength { get; set; }
        public double? ShapeArea { get; set; }
        public string? MiStyle { get; set; }
        public int MiPrinx { get; set; }
    }
}
