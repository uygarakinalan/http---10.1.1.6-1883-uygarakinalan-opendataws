using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class ViewMuhtarSurec
    {
        public int Id { get; set; }
        public int? AtananKisiId { get; set; }
        public DateTime? SurecTarihi { get; set; }
        public int? IlceId { get; set; }
        public int? MahalleId { get; set; }
        public DateTime? SonuclandirmaTarihi { get; set; }
        public int? MudurlukId { get; set; }
        public string? Konu { get; set; }
        public string? Aciklama { get; set; }
        public string? Sonuc { get; set; }
        public string? Notlar { get; set; }
        public int? TalepDurumu { get; set; }
        public string? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? GuncelleyenUserId { get; set; }
        public string? AtananAdisoyadi { get; set; }
        public string? TalepDurumuTxt { get; set; }
        public string? IlceAdi { get; set; }
        public string? MahalleAdi { get; set; }
    }
}
