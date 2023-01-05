using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class TemsilciOfisiMahalle
    {
        public int Id { get; set; }
        public int? OfisId { get; set; }
        public int? MahId { get; set; }
        public int? Aktif { get; set; }
    }
}
