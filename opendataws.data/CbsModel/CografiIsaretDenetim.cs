using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CografiIsaretDenetim
    {
        public int Id { get; set; }
        public DateTime? DenetlemeTarihi { get; set; }
        public DateTime? GelecekDenetlemeTarihi { get; set; }
        public string? DenetimSonuc { get; set; }
        public int? FirmaId { get; set; }
        public string? DenetimSonucAciklama { get; set; }
        public string? FirmaAciklama { get; set; }
        public string? Aciklama { get; set; }
        public int? UrunId { get; set; }
    }
}
