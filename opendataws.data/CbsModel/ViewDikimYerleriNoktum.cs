using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class ViewDikimYerleriNoktum
    {
        public string DikimSuresi { get; set; } = null!;
        public string? Isim { get; set; }
        public string? Ilce { get; set; }
        public string? Mahalle { get; set; }
        public string? CaddeSokak { get; set; }
        public string? DikimTarihi { get; set; }
        public string? SonrakiDikimTarihi { get; set; }
        public string? Aciklama { get; set; }
        public int MiPrinx { get; set; }
    }
}
