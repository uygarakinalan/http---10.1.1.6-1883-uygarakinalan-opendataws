using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class SaglikSosyalFaaliyetler
    {
        public int FaaliyetId { get; set; }
        public int? Miktar { get; set; }
        public string? Aciklama { get; set; }
        public string? Birim { get; set; }
        public double? TurId { get; set; }
        public string? TurAdi { get; set; }
        public double? FaaliyetDurumId { get; set; }
        public string? FaaliyetDurumAd { get; set; }
        public double? OlcuBirimiId { get; set; }
        public string? OlcuBirimi { get; set; }
        public string? MahalleAdi { get; set; }
        public double? MahalleId { get; set; }
        public string? IlceAdi { get; set; }
        public double? IlceKodu { get; set; }
    }
}
