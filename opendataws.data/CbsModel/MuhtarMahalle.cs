using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class MuhtarMahalle
    {
        public int Id { get; set; }
        public int? MahalleId { get; set; }
        public int? MuhtarId { get; set; }
        public int? Aktif { get; set; }
        public string? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? GuncelleyenUserId { get; set; }
    }
}
