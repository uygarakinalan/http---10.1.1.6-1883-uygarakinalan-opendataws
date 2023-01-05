using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsZabitaIsMeslekKollari
    {
        public int MeslekId { get; set; }
        public string? MeslekAdi { get; set; }
        public int? Durum { get; set; }
    }
}
