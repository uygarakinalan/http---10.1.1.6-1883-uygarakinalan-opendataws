using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class MuhtarDuyuru
    {
        public int Id { get; set; }
        public int? IlceId { get; set; }
        public string? IlceAdi { get; set; }
        public string? Baslik { get; set; }
        public string? Aciklama { get; set; }
        public DateTime? Tarih { get; set; }
        public int? Aktif { get; set; }
        public string? Ozet { get; set; }
    }
}
