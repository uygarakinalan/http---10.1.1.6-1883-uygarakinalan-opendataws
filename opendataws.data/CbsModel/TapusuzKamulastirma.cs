using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class TapusuzKamulastirma
    {
        public int MiPrinx { get; set; }
        public int? Turu { get; set; }
        public int? Ada { get; set; }
        public int? Parsel { get; set; }
        public string? Aciklama { get; set; }
        public DateTime? Tarih { get; set; }
        public int? Bedel { get; set; }
        public string? Ilce { get; set; }
        public string? IlceKodu { get; set; }
        public string? Mahalle { get; set; }
        public string? MahalleKodu { get; set; }
        public string? CaddeSokak { get; set; }
        public string? CaddeSokakKodu { get; set; }
        public int? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? MiStyle { get; set; }
    }
}
