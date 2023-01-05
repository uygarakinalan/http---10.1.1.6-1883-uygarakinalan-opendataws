using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class Parkomat4326
    {
        public int? SiraNo { get; set; }
        public string? Bolge { get; set; }
        public string? Adres { get; set; }
        public string? Ilce { get; set; }
        public string? Yon { get; set; }
        public string? Yerlesim { get; set; }
        public int? Uzunluk { get; set; }
        public int? Kapasite { get; set; }
        public string? MiStyle { get; set; }
        public int MiPrinx { get; set; }
        public int? EngelliParkAlani { get; set; }
        public decimal? UcretTarifesi { get; set; }
        public string? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? GuncelleyenUserId { get; set; }
    }
}
