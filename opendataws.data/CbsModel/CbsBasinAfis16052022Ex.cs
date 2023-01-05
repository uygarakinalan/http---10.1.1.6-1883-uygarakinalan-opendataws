using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsBasinAfis16052022Ex
    {
        public int MiPrinx { get; set; }
        public int? BasinId { get; set; }
        public string? Aciklama { get; set; }
        public DateTime? AfisBaslangicTarihi { get; set; }
        public DateTime? AfisBitisTarihi { get; set; }
        public int? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }
        public string? Durum { get; set; }
    }
}
