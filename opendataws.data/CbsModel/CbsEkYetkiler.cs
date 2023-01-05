using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsEkYetkiler
    {
        public int EkyetkiId { get; set; }
        public string? EkyetkiKodu { get; set; }
        public int? OzelId { get; set; }
        public string? Aciklama { get; set; }
        public string? Tur { get; set; }
    }
}
