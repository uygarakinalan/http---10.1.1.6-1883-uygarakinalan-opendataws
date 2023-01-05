﻿using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsItfaiyeEgitimMGAdet
    {
        public int Id { get; set; }
        public int? EgitimId { get; set; }
        public int? MeslekGrupId { get; set; }
        public int? Adet { get; set; }
        public string? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? GuncelleyenUserId { get; set; }
        public string? Aciklama { get; set; }
    }
}
