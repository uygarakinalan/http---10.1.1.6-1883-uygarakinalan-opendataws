using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class SehitListesi
    {
        public int SehitId { get; set; }
        public string? SehidinAdiSoyadi { get; set; }
        public string? RutbeUnvan { get; set; }
        public string? Mensubiyeti { get; set; }
        public string? MedeniDurum { get; set; }
        public string? OlayYeri { get; set; }
        public DateTime? SehadetTarihi { get; set; }
        public string? HakSahibi { get; set; }
        public string? AnneBabaKardesTelefon { get; set; }
        public string? AnneBabaKardesAdres { get; set; }
        public string? Ilce { get; set; }
        public string? HakSahibi1 { get; set; }
        public string? EsCocukTelefon { get; set; }
        public string? EsCocukAdres { get; set; }
        public string? Ilce1 { get; set; }
        public string? Durum { get; set; }
        public int? IlceKodu { get; set; }
        public int? MahalleKodu { get; set; }
        public int? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? AdresTur { get; set; }
    }
}
