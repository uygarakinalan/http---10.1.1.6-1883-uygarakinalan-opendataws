using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsDuyurular
    {
        public int Id { get; set; }
        public string? BirimAdi { get; set; }
        public string? Aciklama { get; set; }
        public DateTime? Tarih { get; set; }
        public int? BirimId { get; set; }
        public int? AktifMi { get; set; }
    }
}
