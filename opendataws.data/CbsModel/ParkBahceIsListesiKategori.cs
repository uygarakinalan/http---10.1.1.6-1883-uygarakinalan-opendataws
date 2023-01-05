using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class ParkBahceIsListesiKategori
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string? Ad { get; set; }
        public int? Aktif { get; set; }
    }
}
