using System;
using System.Collections.Generic;

namespace opendataws.data.MezarlikModels
{
    public partial class KisiYakinlari
    {
        public int Id { get; set; }
        public int? KisiId { get; set; }
        public string? TcKimlikNo { get; set; }
        public string? Adi { get; set; }
        public string? Soyadi { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string? Yakinligi { get; set; }
        public string? Telefon { get; set; }
        public short? Ekleyen { get; set; }
        public DateTime? EklemeTarihi { get; set; }
        public short? Guncelleyen { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public bool? Aktif { get; set; }

        public virtual Kisiler? Kisi { get; set; }
    }
}
