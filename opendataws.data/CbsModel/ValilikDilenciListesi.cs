using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class ValilikDilenciListesi
    {
        public int ValilikDilenciKisiId { get; set; }
        public string? TcNo { get; set; }
        public string? KisiAdresi { get; set; }
        public string? AdiSoyadi { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string? AnneAdi { get; set; }
        public string? BabaAdi { get; set; }
        public string? Cinsiyet { get; set; }
        public string? Uyruk { get; set; }
        public int? ElKonulanMalzemeCinsi { get; set; }
        public int? KayitUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public int? ValilikDilenciId { get; set; }
        public string? BirimAciklama { get; set; }
        public int? Durumu { get; set; }
        public int? HavaleDurumu { get; set; }
        public string? HavaleDurumuAciklama { get; set; }
        public string? IlDisiKapatma { get; set; }
        public int? IlDisiKapatmaDurum { get; set; }
        public int? DilenciSilDurum { get; set; }
        public string? Adresno { get; set; }
        public int? KaydetmeTuru { get; set; }
    }
}
