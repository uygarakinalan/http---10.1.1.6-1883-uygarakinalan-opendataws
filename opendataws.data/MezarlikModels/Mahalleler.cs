using System;
using System.Collections.Generic;

namespace opendataws.data.MezarlikModels
{
    public partial class Mahalleler
    {
        public int Id { get; set; }
        public string Tanim { get; set; } = null!;
        public short? IlceId { get; set; }
        public short? IlId { get; set; }
        public short? Ekleyen { get; set; }
        public DateTime? EklemeTarihi { get; set; }
        public short? Guncelleyen { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public bool? Aktif { get; set; }

        public virtual Iller? Il { get; set; }
        public virtual Ilceler? Ilce { get; set; }
    }
}
