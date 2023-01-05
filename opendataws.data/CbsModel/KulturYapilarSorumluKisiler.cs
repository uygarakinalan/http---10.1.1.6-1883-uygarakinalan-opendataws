using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class KulturYapilarSorumluKisiler
    {
        public int MiPrinx { get; set; }
        public int? KulId { get; set; }
        public int? KulturYapilarId { get; set; }
        public int? Durum { get; set; }
        public int? KaydedenUserid { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? GuncelleyenUserid { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
    }
}
