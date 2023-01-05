using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class TeknikServisMalzemeListesi
    {
        public int MalzemeId { get; set; }
        public string? MalzemeAdi { get; set; }
        public string? MalzemeModelAdi { get; set; }
        public string? OzelKod { get; set; }
        public int? KayitUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
    }
}
