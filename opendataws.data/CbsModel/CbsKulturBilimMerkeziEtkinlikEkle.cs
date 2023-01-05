using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsKulturBilimMerkeziEtkinlikEkle
    {
        public int MiPrinx { get; set; }
        public string? EtkinlikAdi { get; set; }
        public DateTime? EtkinlikTarihi { get; set; }
        public DateTime? EtkinlikBitisTarihi { get; set; }
        public int? OkulId { get; set; }
        public string? OkulAdi { get; set; }
        public int? OgrenciSayisi { get; set; }
        public int? IlceKodu { get; set; }
        public int? MahalleKodu { get; set; }
        public string? Ilce { get; set; }
        public string? Mahalle { get; set; }
        public int? EtkinlikTurKodu { get; set; }
        public string? EtkinlikTurAdi { get; set; }
        public string? IrtibatAdi { get; set; }
        public string? IrtibatTel { get; set; }
        public string? Notlar { get; set; }
        public string? Adres { get; set; }
        public string? OzelKod1 { get; set; }
        public int? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? MiStyle { get; set; }
    }
}
