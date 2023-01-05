using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CografiIsaretBasvuruKurum
    {
        public int Id { get; set; }
        public string? KurumAdi { get; set; }
        public int? KaydedenUserid { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
    }
}
