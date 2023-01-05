using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class ViewBitkiAnlikDepoDurumu
    {
        public int? Fidanlikbolumleriid { get; set; }
        public int? Bitkiid { get; set; }
        public string? DepoBolum { get; set; }
        public string? BitkiAdi { get; set; }
        public int Giren { get; set; }
        public int Cikan { get; set; }
        public int Kuruyan { get; set; }
        public int? Kalan { get; set; }
        public string? Tur { get; set; }
    }
}
