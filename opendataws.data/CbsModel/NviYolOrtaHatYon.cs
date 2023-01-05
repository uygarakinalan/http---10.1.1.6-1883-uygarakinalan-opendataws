using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class NviYolOrtaHatYon
    {
        public int? Objectid { get; set; }
        public string? Id { get; set; }
        public int? Kimlikno { get; set; }
        public int? Baslangicno { get; set; }
        public int? Bitisno { get; set; }
        public string? Tur { get; set; }
        public string? Yolortahatid { get; set; }
        public string? Mahalleid { get; set; }
        public string? Koybaglisiid { get; set; }
        public DateTime? Olusturmatarihi { get; set; }
        public DateTime? Degistirmetarihi { get; set; }
        public int? Uavtkodu { get; set; }
        public string? Sayisallastirmayon { get; set; }
        public double? Olusturan { get; set; }
        public double? Degistiren { get; set; }
        public string? Globalid { get; set; }
        public int? Operationnumber { get; set; }
        public string? Operationdescription { get; set; }
        public string? Tanitimkodu { get; set; }
        public string? Islemgerekcesi { get; set; }
        public string? MiStyle { get; set; }
        public int MiPrinx { get; set; }
    }
}
