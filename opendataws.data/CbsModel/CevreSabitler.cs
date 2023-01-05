using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CevreSabitler
    {
        public int Id { get; set; }
        public string? Adi { get; set; }
        public int? Tur { get; set; }
        public int? Aktif { get; set; }
        public string? Aciklama { get; set; }
        public int? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
    }
}
