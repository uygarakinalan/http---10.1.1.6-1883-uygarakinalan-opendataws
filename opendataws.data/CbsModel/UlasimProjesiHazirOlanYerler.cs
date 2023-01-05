using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class UlasimProjesiHazirOlanYerler
    {
        public int? SiraNo { get; set; }
        public string? Talep { get; set; }
        public string? MahalleAdi { get; set; }
        public string? Konu { get; set; }
        public string? Adres { get; set; }
        public string? Aciklama { get; set; }
        public string? HalihazirDurumu { get; set; }
        public string? ProjeDurumu { get; set; }
        public string? UkomeKarari { get; set; }
        public DateTime? KararTarihi { get; set; }
        public string? IletilmeDurumu { get; set; }
        public string? UygulanmaDurumu { get; set; }
        public int? GeometriTuru { get; set; }
        public string? MiStyle { get; set; }
        public int MiPrinx { get; set; }
    }
}
