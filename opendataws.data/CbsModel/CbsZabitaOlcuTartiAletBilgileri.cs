using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsZabitaOlcuTartiAletBilgileri
    {
        public int AletId { get; set; }
        public DateTime? Tarih { get; set; }
        public int? Adet { get; set; }
        public int? Cinsi { get; set; }
        public string? Markasi { get; set; }
        public string? SeriNo { get; set; }
        public int? Cekeri { get; set; }
        public int? Sinifi { get; set; }
        public string? Agirlik { get; set; }
        public string? Aciklama { get; set; }
        public string? MakbuzSeriNo { get; set; }
        public int? Tutari { get; set; }
        public int? SucunNevisi { get; set; }
        public int? KayitUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public int? OlcuTartiId { get; set; }
    }
}
