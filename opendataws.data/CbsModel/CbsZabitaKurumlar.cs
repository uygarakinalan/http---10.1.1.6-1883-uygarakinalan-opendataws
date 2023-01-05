using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsZabitaKurumlar
    {
        public int KurumId { get; set; }
        public string? KurumAdi { get; set; }
        public int? Durum { get; set; }
    }
}
