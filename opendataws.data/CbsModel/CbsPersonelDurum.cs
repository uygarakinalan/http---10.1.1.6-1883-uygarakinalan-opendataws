using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsPersonelDurum
    {
        public int Id { get; set; }
        public string? Durum { get; set; }
        public int? PersonelTablosuKodu { get; set; }
        public int? OzelKod { get; set; }
    }
}
