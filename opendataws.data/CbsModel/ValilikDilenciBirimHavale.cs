using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class ValilikDilenciBirimHavale
    {
        public int Id { get; set; }
        public int? DilenciKisiId { get; set; }
        public int? BirimId { get; set; }
        public int? SonucTur { get; set; }
        public string? SonucAciklama { get; set; }
        public int? SonucAciklamaTur { get; set; }
        public int? KaydedenUserid { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? GuncelleyenUserid { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? GeriIadeAciklama { get; set; }
    }
}
