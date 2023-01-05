using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class DikimYerleriNoktum
    {
        public decimal? Oid { get; set; }
        public string? Isim { get; set; }
        public string? Ilce { get; set; }
        public string? Mahalle { get; set; }
        public string? CaddeSokak { get; set; }
        public DateTime? DikimTarihi { get; set; }
        public DateTime? SonrakiDikimTarihi { get; set; }
        public string? Aciklama { get; set; }
        public string? MiStyle { get; set; }
        public int MiPrinx { get; set; }
    }
}
