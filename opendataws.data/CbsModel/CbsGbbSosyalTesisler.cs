using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsGbbSosyalTesisler
    {
        public int MiPrinx { get; set; }
        public int? SosyalTesisId { get; set; }
        public string? SosyalTesisAdi { get; set; }
        public int? MulkSahibiId { get; set; }
        public string? Aciklama { get; set; }
        public int? IlceKodu { get; set; }
        public int? MahalleKodu { get; set; }
        public int? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? MiStyle { get; set; }
    }
}
