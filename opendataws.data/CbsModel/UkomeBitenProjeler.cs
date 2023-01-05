using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class UkomeBitenProjeler
    {
        public int? SiraNo { get; set; }
        public string? Konu { get; set; }
        public string? MahalleAdi { get; set; }
        public string? Adres { get; set; }
        public double? Aciklama { get; set; }
        public string? HalihazirDurumu { get; set; }
        public string? UkomeKararNo { get; set; }
        public DateTime? UkomeKararTarihi { get; set; }
        public string? Durum { get; set; }
        public int? GeometriTuru { get; set; }
        public int MiPrinx { get; set; }
        public string? MiStyle { get; set; }
    }
}
