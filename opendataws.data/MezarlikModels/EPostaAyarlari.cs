using System;
using System.Collections.Generic;

namespace opendataws.data.MezarlikModels
{
    public partial class EPostaAyarlari
    {
        public short Id { get; set; }
        public string? Eposta { get; set; }
        public string? Parola { get; set; }
        public string? SmtpAdres { get; set; }
        public int? Port { get; set; }
        public bool? Ssl { get; set; }
        public short? Ekleyen { get; set; }
        public DateTime? EklemeTarihi { get; set; }
        public short? Guncelleyen { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public bool? Aktif { get; set; }
    }
}
