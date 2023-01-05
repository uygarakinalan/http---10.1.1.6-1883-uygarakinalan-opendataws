using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class ViewCbsItfaiyeYanginRaporuOluYarali
    {
        public int Id { get; set; }
        public string? Cinsiyet { get; set; }
        public string? UyrukAciklama { get; set; }
        public string? PersonelHalk { get; set; }
        public int? IhbarId { get; set; }
        public string? Tur { get; set; }
        public string? AdSoyad { get; set; }
        public string EngelDurumu { get; set; } = null!;
        public string Uyruk { get; set; } = null!;
        public int? IhbarTuru { get; set; }
        public string? Yas { get; set; }
    }
}
