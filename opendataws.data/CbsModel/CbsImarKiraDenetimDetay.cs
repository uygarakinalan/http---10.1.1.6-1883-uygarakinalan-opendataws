using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsImarKiraDenetimDetay
    {
        public int DenetimDetayId { get; set; }
        public int? DenetimKonusuId { get; set; }
        public string? DenetimKonusuDurumu { get; set; }
        public int? KiraDenetimId { get; set; }
    }
}
