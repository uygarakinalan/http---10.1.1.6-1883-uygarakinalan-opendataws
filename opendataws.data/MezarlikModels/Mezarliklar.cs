using System;
using System.Collections.Generic;

namespace opendataws.data.MezarlikModels
{
    public partial class Mezarliklar
    {
        public Mezarliklar()
        {
            AileMezarliks = new HashSet<AileMezarlik>();
            Kisilers = new HashSet<Kisiler>();
        }

        public byte Id { get; set; }
        public string Tanim { get; set; } = null!;
        public short? IlceId { get; set; }
        public short? SorumluKullaniciId { get; set; }
        public string? Adres { get; set; }
        public string? Telefon { get; set; }
        public short? Ekleyen { get; set; }
        public DateTime? EklemeTarihi { get; set; }
        public short? Guncelleyen { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public bool? Aktif { get; set; }

        public virtual Ilceler? Ilce { get; set; }
        public virtual Kullanicilar? SorumluKullanici { get; set; }
        public virtual ICollection<AileMezarlik> AileMezarliks { get; set; }
        public virtual ICollection<Kisiler> Kisilers { get; set; }
    }
}
