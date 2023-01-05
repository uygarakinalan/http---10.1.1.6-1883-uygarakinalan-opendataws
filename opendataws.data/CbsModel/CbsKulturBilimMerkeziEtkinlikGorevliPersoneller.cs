using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsKulturBilimMerkeziEtkinlikGorevliPersoneller
    {
        public int Id { get; set; }
        public int? PersonelId { get; set; }
        public int EtkinlikId { get; set; }
        public int? KaydedenUserid { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? GuncelleyenUserid { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
    }
}
