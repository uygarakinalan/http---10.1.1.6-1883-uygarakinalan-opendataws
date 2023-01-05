using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class ViewYanginraporuEkipPersonelListesi
    {
        public int Id { get; set; }
        public int? PersonelId { get; set; }
        public int? IhbarId { get; set; }
        public string? Tur { get; set; }
        public string? AdSoyad { get; set; }
        public string? Gorevi { get; set; }
    }
}
