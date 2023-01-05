using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class NviYolEski
    {
        public int? Objectid { get; set; }
        public string? Id { get; set; }
        public string? Ad { get; set; }
        public int? Kimlikno { get; set; }
        public string? Tip { get; set; }
        public int? Tekbaslangicno { get; set; }
        public int? Tekbitisno { get; set; }
        public int? Ciftbaslangicno { get; set; }
        public int? Ciftbitisno { get; set; }
        public DateTime? Olusturmatarihi { get; set; }
        public DateTime? Degistirmetarihi { get; set; }
        public double? Olusturan { get; set; }
        public double? Degistiren { get; set; }
        public string? Globalid { get; set; }
        public int? Operationnumber { get; set; }
        public string? Operationdescription { get; set; }
        public string? Islemgerekcesi { get; set; }
        public string? MiStyle { get; set; }
        public int MiPrinx { get; set; }
    }
}
