using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsBitkiDikimAlanEnvanter
    {
        public int Id { get; set; }
        public int? DikimAlanId { get; set; }
        public int? FidanlikBolumleriId { get; set; }
        public int? BitkiId { get; set; }
        public int? BitkiSayisi { get; set; }
        public int? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }

        public virtual CbsBitkiler? Bitki { get; set; }
    }
}
