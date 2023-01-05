using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class KulturYapilarAtolye
    {
        public int Id { get; set; }
        public int? KulturYapilarId { get; set; }
        public int? AtolyeId { get; set; }
        public int? KatilanSayisi { get; set; }
        public string? Aciklama { get; set; }
        public DateTime? Tarih { get; set; }
        public int? Aktif { get; set; }
        public int? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }

        public virtual KulturYapilarAtolyeTur? Atolye { get; set; }
        public virtual KulturYapilar? KulturYapilar { get; set; }
    }
}
