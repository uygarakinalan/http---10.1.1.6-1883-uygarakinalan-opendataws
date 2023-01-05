using System;
using System.Collections.Generic;

namespace opendataws.data.MezarlikModels
{
    public partial class Iller
    {
        public Iller()
        {
            Ilcelers = new HashSet<Ilceler>();
            Kisilers = new HashSet<Kisiler>();
            Mahallelers = new HashSet<Mahalleler>();
        }

        public short Id { get; set; }
        public string Tanim { get; set; } = null!;
        public short? Ekleyen { get; set; }
        public DateTime? EklemeTarihi { get; set; }
        public short? Guncelleyen { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public bool? Aktif { get; set; }

        public virtual ICollection<Ilceler> Ilcelers { get; set; }
        public virtual ICollection<Kisiler> Kisilers { get; set; }
        public virtual ICollection<Mahalleler> Mahallelers { get; set; }
    }
}
