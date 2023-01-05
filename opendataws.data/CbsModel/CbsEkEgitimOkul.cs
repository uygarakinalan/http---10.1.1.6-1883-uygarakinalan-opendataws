using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsEkEgitimOkul
    {
        public int EtkinlikId { get; set; }
        public string? EtkinlikKategorisi { get; set; }
        public DateTime? EtkinlikBaslamaTarihi { get; set; }
        public DateTime? EtkinlikBitisTarihi { get; set; }
        public string? YazKisOkulu { get; set; }
        public string? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public string? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public int? Durum { get; set; }
        public string? FaaliyetBilgisi { get; set; }
        public int? FaaliyetBilgisiId { get; set; }
    }
}
