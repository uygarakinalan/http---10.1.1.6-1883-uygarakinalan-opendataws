using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class EngGebeListesi
    {
        public int MiPrinx { get; set; }
        public string? TcNo { get; set; }
        public string? AdiSoyadi { get; set; }
        public string? Telefon { get; set; }
        public string? Adres { get; set; }
        public string? NviAd { get; set; }
        public string? NviSoyad { get; set; }
        public string? NviAcikAdres { get; set; }
        public long? NviBagimsizNo { get; set; }
        public int? NviBinaNo { get; set; }
        public string? HataBilgisi { get; set; }
        public string? Uyruk { get; set; }
        public DateTime? SonAdetTarihi { get; set; }
        public string? MiStyle { get; set; }
        public int? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public int? Aktif { get; set; }
    }
}
