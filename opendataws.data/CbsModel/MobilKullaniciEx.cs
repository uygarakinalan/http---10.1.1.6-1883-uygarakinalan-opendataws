using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class MobilKullaniciEx
    {
        public int Id { get; set; }
        public string? KulAdi { get; set; }
        public string? KulSifre { get; set; }
        public string? KulEmail { get; set; }
        public string? KulAdiSoyadi { get; set; }
        public int? Yetki { get; set; }
        public int? UstBirimId { get; set; }
        public int? BirimId { get; set; }
        public int? GrupId { get; set; }
        public string? KulIp { get; set; }
        public int? Durum { get; set; }
    }
}
