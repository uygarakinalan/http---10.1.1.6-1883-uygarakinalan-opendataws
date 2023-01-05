using System;
using System.Collections.Generic;

namespace opendataws.data.MezarlikModels
{
    public partial class OlumSebepleri
    {
        public OlumSebepleri()
        {
            Kisilers = new HashSet<Kisiler>();
        }

        public int Id { get; set; }
        public string Tanim { get; set; } = null!;
        public short? Ekleyen { get; set; }
        public DateTime? EklemeTarihi { get; set; }
        public short? Guncelleyen { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public bool? Aktif { get; set; }
        public decimal? Version { get; set; }

        public virtual ICollection<Kisiler> Kisilers { get; set; }
    }
}
