using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class TeknikServisBirimEnvanterDetay
    {
        public int EnvanterDetayId { get; set; }
        public int? MalzemeId { get; set; }
        public int? MalzemeAdet { get; set; }
        public string? MalzemeModelAdi { get; set; }
        public int? KayitUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public int? EnvanterBirimId { get; set; }
    }
}
