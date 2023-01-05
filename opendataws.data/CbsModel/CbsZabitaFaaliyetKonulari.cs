using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsZabitaFaaliyetKonulari
    {
        public int KonuId { get; set; }
        public string? FaaliyetKonusu { get; set; }
        public string? OzelKod { get; set; }
        public int? Durum { get; set; }
    }
}
