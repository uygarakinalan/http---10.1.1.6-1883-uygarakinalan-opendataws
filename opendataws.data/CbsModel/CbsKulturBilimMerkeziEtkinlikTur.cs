using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsKulturBilimMerkeziEtkinlikTur
    {
        public int Id { get; set; }
        public string? TurAdi { get; set; }
        public string? OzelKod { get; set; }
        public int? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
    }
}
