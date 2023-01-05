using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class ParkBahceIsListesiKayitBuNedirEx
    {
        public int Id { get; set; }
        public string? EkipAdi { get; set; }
        public string? EkipSayisi { get; set; }
        public string? YapilanIs { get; set; }
        public DateTime? IsinTarihi { get; set; }
        public string? UygulanilanAlan { get; set; }
        public string? KullanilanMateryal { get; set; }
        public string? GunlukAdetDoz { get; set; }
        public string? GenelDurum { get; set; }
        public string? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public string? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
    }
}
