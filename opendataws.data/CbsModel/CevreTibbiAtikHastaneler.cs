using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CevreTibbiAtikHastaneler
    {
        public int MiPrinx { get; set; }
        public string? KurumAdi { get; set; }
        public int? IlceKodu { get; set; }
        public int? MahalleKodu { get; set; }
        public int? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? MiStyle { get; set; }
    }
}
