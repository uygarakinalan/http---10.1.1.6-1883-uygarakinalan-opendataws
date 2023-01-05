using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class ViewKatiAtikVerileri
    {
        public decimal? Ocak { get; set; }
        public decimal? Subat { get; set; }
        public decimal? Mart { get; set; }
        public decimal? Nisan { get; set; }
        public decimal? Mayis { get; set; }
        public decimal? Haziran { get; set; }
        public decimal? Temmuz { get; set; }
        public decimal? Agustos { get; set; }
        public decimal? Eylul { get; set; }
        public decimal? Ekim { get; set; }
        public decimal? Kasim { get; set; }
        public decimal? Aralik { get; set; }
        public string? Aciklama { get; set; }
        public int? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public int? Ilce { get; set; }
        public int? Yil { get; set; }
        public string? Birim { get; set; }
        public int? EslemeId { get; set; }
        public string? MiStyle { get; set; }
        public int MiPrinx { get; set; }
        public string? IlceAdi { get; set; }
        public decimal? Toplam { get; set; }
    }
}
