using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsBitkiDikimAlan
    {
        public int MiPrinx { get; set; }
        public DateTime? CikisTarihi { get; set; }
        public string? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? GuncelleyenUserId { get; set; }
        public string? GonderilenYer { get; set; }
        public string? GonderilenArac { get; set; }
        public string? GonderilenAracSoforu { get; set; }
        public int? PersonelId { get; set; }
        public string? MiStyle { get; set; }
        public string? EskiGeom { get; set; }
        public int? Durum { get; set; }
        public int? Tur { get; set; }
    }
}
