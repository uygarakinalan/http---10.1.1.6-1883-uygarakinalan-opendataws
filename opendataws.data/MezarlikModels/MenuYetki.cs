using System;
using System.Collections.Generic;

namespace opendataws.data.MezarlikModels
{
    public partial class MenuYetki
    {
        public int Id { get; set; }
        public short KullaniciId { get; set; }
        public short MenuId { get; set; }
        public bool Gorunurluk { get; set; }
        public short Ekleyen { get; set; }
        public DateTime EklemeTarihi { get; set; }
        public short? Guncelleyen { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public bool? Aktif { get; set; }

        public virtual Kullanicilar Kullanici { get; set; } = null!;
        public virtual Menuler Menu { get; set; } = null!;
    }
}
