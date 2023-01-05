using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsImarKiraDenetimKonulari
    {
        public int KonuId { get; set; }
        public string? Konu { get; set; }
        public int? AktifMi { get; set; }
        public int? Tur { get; set; }
    }
}
