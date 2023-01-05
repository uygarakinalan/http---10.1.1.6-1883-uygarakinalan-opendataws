using System;
using System.Collections.Generic;

namespace opendataws.data.MezarlikModels
{
    public partial class Duyurular
    {
        public int Id { get; set; }
        public string Baslik { get; set; } = null!;
        public string Icerik { get; set; } = null!;
        public DateTime YayinlanmaTarihi { get; set; }
        public short? Ekleyen { get; set; }
        public DateTime? EklemeTarihi { get; set; }
        public short? Guncelleyen { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public bool? Aktif { get; set; }
    }
}
