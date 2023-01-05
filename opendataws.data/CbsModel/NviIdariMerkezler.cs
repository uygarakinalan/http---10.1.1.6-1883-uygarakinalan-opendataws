using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class NviIdariMerkezler
    {
        public int? Objectid { get; set; }
        public string? Id { get; set; }
        public string? Adi { get; set; }
        public int? Kimlikno { get; set; }
        public int? Tip { get; set; }
        public string? Idariyapiid { get; set; }
        public string? Globalid { get; set; }
        public DateTime? Olusturmatarihi { get; set; }
        public DateTime? Degistirmetarihi { get; set; }
        public double? Olusturan { get; set; }
        public double? Degistiren { get; set; }
        public int? Operationnumber { get; set; }
        public string? Operationdescription { get; set; }
        public string? MiStyle { get; set; }
        public int MiPrinx { get; set; }
    }
}
