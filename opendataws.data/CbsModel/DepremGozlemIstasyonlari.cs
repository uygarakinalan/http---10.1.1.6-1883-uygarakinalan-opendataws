using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class DepremGozlemIstasyonlari
    {
        public int? Objectid { get; set; }
        public string? Kurum { get; set; }
        public string? IstasyonAdi { get; set; }
        public string? Ilce { get; set; }
        public string? Mahalle { get; set; }
        public string? Durumu { get; set; }
        public string? Adres { get; set; }
        public string? Il { get; set; }
        public string? MiStyle { get; set; }
        public int MiPrinx { get; set; }
    }
}
