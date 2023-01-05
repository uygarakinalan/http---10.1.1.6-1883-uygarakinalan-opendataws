using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class KulturYapilarMuze
    {
        public int Id { get; set; }
        public int? KulturYapilarId { get; set; }
        public int? KadinZiyaretciSayisi { get; set; }
        public int? ErkekZiyaretciSayisi { get; set; }
        public int? CocukZiyaretciSayisi { get; set; }
        public int? YetiskinZiyaretciSayisi { get; set; }
        public int? YerliZiyaretciSayisi { get; set; }
        public int? YabanciZiyaretciSayisi { get; set; }
        public int? PersonelSayisi { get; set; }
        public DateTime? ZiyaretTarihi { get; set; }
        public string? Aciklama { get; set; }
        public int? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public int? Aktif { get; set; }
    }
}
