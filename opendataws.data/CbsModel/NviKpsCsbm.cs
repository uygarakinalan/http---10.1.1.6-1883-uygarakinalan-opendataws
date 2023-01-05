using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class NviKpsCsbm
    {
        public int MiPrinx { get; set; }
        public string? CsbmAdi { get; set; }
        public int? CsbmUavtKodu { get; set; }
        public DateTime? EsitlemeTarihi { get; set; }
        public string? GelismislikDurumAciklama { get; set; }
        public int? GelismislikDurumKod { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? GuncelleyenUserId { get; set; }
        public string? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? MahalleUavtKodu { get; set; }
        public string? TipiAciklama { get; set; }
        public int? TipiKod { get; set; }
        public int? WcfGuncellemeDurum { get; set; }
    }
}
