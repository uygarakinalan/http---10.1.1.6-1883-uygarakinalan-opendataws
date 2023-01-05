using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class ViewFaaliyet
    {
        public double? IlceKodu { get; set; }
        public double? MahalleId { get; set; }
        public string? FaaliyetiYapanBirim { get; set; }
        public string? Kategori { get; set; }
        public string? Aciklama { get; set; }
        public string? ToplamMaliyet { get; set; }
        public string? ToplamMiktar { get; set; }
        public string FaaliyetiYapanBirimId { get; set; } = null!;
    }
}
