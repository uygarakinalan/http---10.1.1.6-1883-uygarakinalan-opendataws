using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class ViewYanginraporuEkipAracListesi
    {
        public int Id { get; set; }
        public int? AracId { get; set; }
        public string? AracPlaka { get; set; }
        public string? SubeAdi { get; set; }
        public int? IhbarId { get; set; }
        public string? Tur { get; set; }
    }
}
