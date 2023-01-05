using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsBitkiDosyaKodlari
    {
        public int Id { get; set; }
        public string? DosyaKodu { get; set; }
        public string? Konusu { get; set; }
        public string? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? GuncelleyenUserId { get; set; }
    }
}
