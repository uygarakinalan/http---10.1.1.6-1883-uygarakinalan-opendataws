using System;
using System.Collections.Generic;

namespace opendataws.data.MezarlikModels
{
    public partial class EskiKayitlar03072017
    {
        public int Id { get; set; }
        public string? Adi { get; set; }
        public string? Soyadi { get; set; }
        public string? AnaAdi { get; set; }
        public string? BabaAdi { get; set; }
        public string? Cinsiyet { get; set; }
        public string? DogumTarihi { get; set; }
        public string? Mahallesi { get; set; }
        public string? SiraNo { get; set; }
        public string? UmumiSiraNo { get; set; }
        public DateTime? OlumTarihi { get; set; }
        public string? OlumSebebi { get; set; }
        public string? RuhsatTarihi { get; set; }
        public string? RuhsatNo { get; set; }
        public string? MakbuzTarihi { get; set; }
        public string? MakbuzNo { get; set; }
        public string? Aciklama { get; set; }
        public string? HekimAdi { get; set; }
        public string? KurumAdi { get; set; }
        public byte? MezarliklarId { get; set; }
        public string? AdaNo { get; set; }
        public string? Parsel { get; set; }
        public string? Yol { get; set; }
        public string? Telefon { get; set; }
        public string? AileMezarNo { get; set; }
        public bool? Hatasiz { get; set; }
        public short? Ekleyen { get; set; }
        public DateTime? EklemeTarihi { get; set; }
        public short? Guncelleyen { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public bool? Aktif { get; set; }
    }
}
