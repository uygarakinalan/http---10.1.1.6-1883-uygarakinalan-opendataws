using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsBitkiKuruyanCiki
    {
        public int MiPrinx { get; set; }
        public DateTime? CikisTarihi { get; set; }
        public string? Aciklama { get; set; }
        public int? FidanlikBolumleriId { get; set; }
        public int? BitkiId { get; set; }
        public int? BitkiSayisi { get; set; }
        public string? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? GuncelleyenUserId { get; set; }
        public int? CikisTuru { get; set; }
    }
}
