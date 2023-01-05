using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class TkgmMahalle
    {
        public int MiPrinx { get; set; }
        public int? MahalleId { get; set; }
        public string? MahalleAdi { get; set; }
        public string? AktifMi { get; set; }
        public string? Tip { get; set; }
        public int? KurumId { get; set; }
        public int? IlceKodu { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? KaydedenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }
        public string? MiStyle { get; set; }
        public string? SpGeometryText { get; set; }
    }
}
