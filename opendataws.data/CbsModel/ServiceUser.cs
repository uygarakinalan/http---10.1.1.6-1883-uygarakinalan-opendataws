using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class ServiceUser
    {
        public int KulId { get; set; }
        public string? KulAdi { get; set; }
        public string? KulSifre { get; set; }
        public string? KulEmail { get; set; }
        public string? KulAdiSoyadi { get; set; }
        public int? KulGrup { get; set; }
        public DateTime? KulSongiris { get; set; }
        public int? PerId { get; set; }
        public int? Durum { get; set; }
        public int? BirimId { get; set; }
        public int? AltBirimId { get; set; }
        public int? KulGirisDurumu { get; set; }
        public string? KulIp { get; set; }
        public int? KurumId { get; set; }
        public string? KulTc { get; set; }
        public string? ServiceTuru { get; set; }
    }
}
