using System;
using System.Collections.Generic;

namespace opendataws.data.MezarlikModels
{
    public partial class Kolonlar
    {
        public int Id { get; set; }
        public short KullaniciId { get; set; }
        public string TabloAdi { get; set; } = null!;
        public string? KolonAdi { get; set; }
        public int? Genislik { get; set; }
        public bool? Gorunurluk { get; set; }
        public short? SiraNo { get; set; }
        public short Ekleyen { get; set; }
        public DateTime EklemeTarihi { get; set; }
        public short? Guncelleyen { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public bool? Aktif { get; set; }

        public virtual Kullanicilar Kullanici { get; set; } = null!;
    }
}
