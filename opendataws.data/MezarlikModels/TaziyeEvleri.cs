using System;
using System.Collections.Generic;

namespace opendataws.data.MezarlikModels
{
    public partial class TaziyeEvleri
    {
        public TaziyeEvleri()
        {
            TaziyeEviPlanlamas = new HashSet<TaziyeEviPlanlama>();
        }

        public int Id { get; set; }
        public string? Tanim { get; set; }
        public int? IlceId { get; set; }
        public int? MahalleId { get; set; }
        public string? Adres { get; set; }
        public string? Telefon { get; set; }
        public string? Yetkili { get; set; }
        public short? Ekleyen { get; set; }
        public DateTime? EklemeTarihi { get; set; }
        public short? Guncelleyen { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public bool? Aktif { get; set; }
        public long? Version { get; set; }

        public virtual ICollection<TaziyeEviPlanlama> TaziyeEviPlanlamas { get; set; }
    }
}
