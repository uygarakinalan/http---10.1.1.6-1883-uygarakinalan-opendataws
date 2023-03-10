using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class GidaYardimValilikYedek
    {
        public int GidaYardimValilikId { get; set; }
        public double? SiraNo { get; set; }
        public string? BasvuranAd { get; set; }
        public string? BasvuranSoyad { get; set; }
        public string? BasvuranTcNo { get; set; }
        public string? BasvuranCepTelefonu { get; set; }
        public string? Adres { get; set; }
        public string? IlceKodu { get; set; }
        public string? MahalleKodu { get; set; }
        public string? BinaKodu { get; set; }
        public string? BagimsizKodu { get; set; }
        public string? NviAcikAdres { get; set; }
        public int? Tur { get; set; }
        public string? Aciklama { get; set; }
        public string? SpGeometry1 { get; set; }
        public int? IsletenId { get; set; }
        public int? IsletenKullaniciId { get; set; }
        public DateTime? EklemeTarihi { get; set; }
        public int? OnayDurum { get; set; }
        public string? BeyanIlceKod { get; set; }
        public string? BeyanMahKod { get; set; }
        public string? BeyanBinaKod { get; set; }
        public string? BeyanBagimsizKod { get; set; }
        public int? BeyanAdres { get; set; }
        public string? BeyanAcikAdres { get; set; }
        public int? SorguSayac { get; set; }
        public string? BeyanLat { get; set; }
        public string? BeyanLon { get; set; }
        public string? BeyanCsbmKod { get; set; }
        public int? GidaTempId { get; set; }
        public string? NviHataBilgisi { get; set; }
        public string? GidaTempAdSoyad { get; set; }
        public string? GidaTempTabloAdi { get; set; }
        public string? GidaTempDosyaAdi { get; set; }
        public string? GidaTempDurumu { get; set; }
        public string? GidaTempYardimProgrami { get; set; }
        public int? GidaYardimValilikTeslimTurId { get; set; }
        public DateTime? GidaYardimValilikTeslimTarihi { get; set; }
        public int? GidaYardimValilikVersiyonNo { get; set; }
        public int? GidaYardimValilikTeslimTurIdEk { get; set; }
    }
}
