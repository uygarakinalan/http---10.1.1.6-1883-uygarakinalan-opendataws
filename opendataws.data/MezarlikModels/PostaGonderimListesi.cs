using System;
using System.Collections.Generic;

namespace opendataws.data.MezarlikModels
{
    public partial class PostaGonderimListesi
    {
        public short Id { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public string? PostaAdresi { get; set; }
        public short? Ekleyen { get; set; }
        public DateTime? EklemeTarihi { get; set; }
        public short? Guncelleyen { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public bool? Aktif { get; set; }
    }
}
