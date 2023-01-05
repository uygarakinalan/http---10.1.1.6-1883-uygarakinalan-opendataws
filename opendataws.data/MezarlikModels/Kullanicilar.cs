using System;
using System.Collections.Generic;

namespace opendataws.data.MezarlikModels
{
    public partial class Kullanicilar
    {
        public Kullanicilar()
        {
            Kolonlars = new HashSet<Kolonlar>();
            MenuYetkis = new HashSet<MenuYetki>();
            Mezarliklars = new HashSet<Mezarliklar>();
        }

        public short Id { get; set; }
        public string KullaniciAdi { get; set; } = null!;
        public string Parola { get; set; } = null!;
        public string Adi { get; set; } = null!;
        public string Soyadi { get; set; } = null!;
        public string? SonGirilenIp { get; set; }
        public string? Telefon { get; set; }
        public string? MezarlikYetki { get; set; }
        public byte[]? Resim { get; set; }
        public short? IlceId { get; set; }
        public short? Ekleyen { get; set; }
        public DateTime? EklemeTarihi { get; set; }
        public short? Guncelleyen { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public bool? Aktif { get; set; }

        public virtual Ilceler? Ilce { get; set; }
        public virtual ICollection<Kolonlar> Kolonlars { get; set; }
        public virtual ICollection<MenuYetki> MenuYetkis { get; set; }
        public virtual ICollection<Mezarliklar> Mezarliklars { get; set; }
    }
}
