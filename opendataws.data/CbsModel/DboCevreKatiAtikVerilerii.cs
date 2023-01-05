using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class DboCevreKatiAtikVerilerii
    {
        public string? Aciklama { get; set; }
        public int? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? Ilce { get; set; }
        public string? EslemeId { get; set; }
        public string? MiStyle { get; set; }
        public int MiPrinx { get; set; }
        public double? SiraNo { get; set; }
        public double? Ocak { get; set; }
        public double? Subat { get; set; }
        public double? Mart { get; set; }
        public double? Nisan { get; set; }
        public double? Mayis { get; set; }
        public double? Haziran { get; set; }
        public double? Temmuz { get; set; }
        public double? Agustos { get; set; }
        public double? Eylul { get; set; }
        public double? Ekim { get; set; }
        public double? Kasim { get; set; }
        public double? Aralik { get; set; }
        public double? ToplamBirimdenGelen { get; set; }
        public string? Birim { get; set; }
        public int? Yil { get; set; }
    }
}
