using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class ViewCevreTesisler
    {
        public string? TesisAdi { get; set; }
        public string? Aciklama { get; set; }
        public string? BagliOlduguBirim { get; set; }
        public string? Adres { get; set; }
        public string? IrtibatKisisi { get; set; }
        public string? Telefon { get; set; }
        public string? Ilce { get; set; }
        public int? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public int? IlceKodu { get; set; }
        public int? MahalleKodu { get; set; }
        public int? EslemeId { get; set; }
        public string? MiStyle { get; set; }
        public int MiPrinx { get; set; }
        public double? Kapasite { get; set; }
        public string? TesisBilgisi { get; set; }
    }
}
