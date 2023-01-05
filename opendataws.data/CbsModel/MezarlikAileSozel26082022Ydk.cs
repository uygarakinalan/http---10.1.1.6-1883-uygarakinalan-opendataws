using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class MezarlikAileSozel26082022Ydk
    {
        public int Id { get; set; }
        public string? IslemNo { get; set; }
        public string? IslemCinsi { get; set; }
        public int? SiraNo { get; set; }
        public byte? Adet { get; set; }
        public byte? MezarliklarId { get; set; }
        public string? TcKimlikNo { get; set; }
        public string? Adi { get; set; }
        public string? Soyadi { get; set; }
        public string? Mahalle { get; set; }
        public decimal? Bedeli { get; set; }
        public string? MakbuzNo { get; set; }
        public DateTime? MakbuzTarihi { get; set; }
        public string? Telefon { get; set; }
        public string? Path { get; set; }
        public string? Ada { get; set; }
        public string? Aciklama { get; set; }
        public string? Gecit { get; set; }
        public string? Cadde { get; set; }
        public int? EskiId { get; set; }
        public bool? Dolu { get; set; }
        public byte? DefinSayisi { get; set; }
        public bool? Ucretsiz { get; set; }
        public short? Ekleyen { get; set; }
        public DateTime? EklemeTarihi { get; set; }
        public short? Guncelleyen { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public bool? Aktif { get; set; }
        public string? AileMezar { get; set; }
        public string? AileSira { get; set; }
        public string? MezarSayi { get; set; }
        public string? MiStyle { get; set; }
        public int MiPrinx { get; set; }
    }
}
