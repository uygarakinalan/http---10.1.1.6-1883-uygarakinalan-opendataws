using System;
using System.Collections.Generic;

namespace opendataws.data.MezarlikModels
{
    public partial class MezarlikYetki
    {
        public int Id { get; set; }
        public string? MezarlikYetki1 { get; set; }
        public short? KullaniciId { get; set; }
        public short? IlceId { get; set; }
        public short? Ekleyen { get; set; }
        public DateTime? EklemeTarihi { get; set; }
        public short? Guncelleyen { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public bool? Aktif { get; set; }
        public decimal? Version { get; set; }
    }
}
