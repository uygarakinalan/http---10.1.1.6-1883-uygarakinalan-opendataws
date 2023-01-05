using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class KulturYapilarKutuphane
    {
        public int Id { get; set; }
        public int? KulturYapilarId { get; set; }
        public int? UyeSayisi { get; set; }
        public int? OduncVerilenMateryalSayisi { get; set; }
        public int? IadeEdilenMateryalSayisi { get; set; }
        public int? CocukZiyaretciSayisi { get; set; }
        public int? YetiskinZiyaretciSayisi { get; set; }
        public int? GrupSayisi { get; set; }
        public string? GrupAciklama { get; set; }
        public DateTime? Tarih { get; set; }
        public int? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public int? Aktif { get; set; }

        public virtual KulturYapilar? KulturYapilar { get; set; }
    }
}
