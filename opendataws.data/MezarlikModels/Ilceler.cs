using System;
using System.Collections.Generic;

namespace opendataws.data.MezarlikModels
{
    public partial class Ilceler
    {
        public Ilceler()
        {
            Kisilers = new HashSet<Kisiler>();
            Kullanicilars = new HashSet<Kullanicilar>();
            Mahallelers = new HashSet<Mahalleler>();
            Mezarliklars = new HashSet<Mezarliklar>();
        }

        public short Id { get; set; }
        public string? Tanim { get; set; }
        public string? Kod { get; set; }
        public short? IlId { get; set; }
        public short? Ekleyen { get; set; }
        public DateTime? EklemeTarihi { get; set; }
        public short? Guncelleyen { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public bool? Aktif { get; set; }

        public virtual Iller? Il { get; set; }
        public virtual ICollection<Kisiler> Kisilers { get; set; }
        public virtual ICollection<Kullanicilar> Kullanicilars { get; set; }
        public virtual ICollection<Mahalleler> Mahallelers { get; set; }
        public virtual ICollection<Mezarliklar> Mezarliklars { get; set; }
    }
}
