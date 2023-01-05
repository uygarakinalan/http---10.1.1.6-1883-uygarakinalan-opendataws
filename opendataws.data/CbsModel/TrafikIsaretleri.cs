using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class TrafikIsaretleri
    {
        public int Id { get; set; }
        public string? LevhaKodu { get; set; }
        public string? LevhaTanimi { get; set; }
        public string? LevhaTipi { get; set; }
        public string? LevhaGeometrisi { get; set; }
    }
}
