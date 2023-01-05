using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsItfaiyePersonelKilo
    {
        public int Id { get; set; }
        public int? PersonelId { get; set; }
        public decimal? Kilo { get; set; }
        public DateTime? OlcmeTarihi { get; set; }
        public string? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? GuncelleyenUserId { get; set; }
        public int? Mekik { get; set; }
        public int? Sinav { get; set; }
        public decimal? Kosu { get; set; }
        public string? Aciklama { get; set; }
    }
}
