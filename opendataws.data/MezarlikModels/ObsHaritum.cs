using System;
using System.Collections.Generic;

namespace opendataws.data.MezarlikModels
{
    public partial class ObsHaritum
    {
        public int Id { get; set; }
        public int KisiId { get; set; }
        public int? BinaKodu { get; set; }
        public int? BinaNo { get; set; }
        public string? LatLng { get; set; }
        public bool? AdresVarMi { get; set; }
        public short? Ekleyen { get; set; }
        public DateTime? EklemeTarihi { get; set; }
        public short? Guncelleyen { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public bool? Aktif { get; set; }

        public virtual Kisiler Kisi { get; set; } = null!;
    }
}
