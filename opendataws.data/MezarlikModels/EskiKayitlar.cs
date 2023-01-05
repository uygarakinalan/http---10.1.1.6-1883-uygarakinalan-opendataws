using System;
using System.Collections.Generic;

namespace opendataws.data.MezarlikModels
{
    public partial class EskiKayitlar
    {
        public int Id { get; set; }
        public string? Adi { get; set; }
        public string? Soyadi { get; set; }
        public string? AnaAdi { get; set; }
        public string? BabaAdi { get; set; }
        public string? Cinsiyet { get; set; }
        public string? DogumTarihi { get; set; }
        public string? Mahallesi { get; set; }
        public string? SiraNo { get; set; }
        public string? UmumiSiraNo { get; set; }
        public string? OlumTarihi { get; set; }
        public string? OlumSebebi { get; set; }
        public string? RuhsatTarihi { get; set; }
        public string? RuhsatNo { get; set; }
        public string? MakbuzTarihi { get; set; }
        public string? MakbuzNo { get; set; }
        public string? Aciklama { get; set; }
        public string? HekimAdi { get; set; }
        public string? KurumAdi { get; set; }
        public byte? MezarliklarId { get; set; }
        public string? AdaNo { get; set; }
        public string? Parsel { get; set; }
        public string? Yol { get; set; }
        public string? Telefon { get; set; }
        public string? AileMezarNo { get; set; }
        public bool? Hatasiz { get; set; }
        public string? TcKimlikNo { get; set; }
        public string? NufusIlce { get; set; }
        public string? NufusIlceKodu { get; set; }
        public string? NufusMahalle { get; set; }
        public string? CiltNo { get; set; }
        public string? AileSiraNo { get; set; }
        public string? BireySiraNo { get; set; }
        public string? DogumYeri { get; set; }
        public string? DogumTarihiYaziIle { get; set; }
        public string? MedeniHal { get; set; }
        public string? Din { get; set; }
        public string? OlumYeri { get; set; }
        public string? OlumTarihiYaziIle { get; set; }
        public string? BildirimTcKimlikNo { get; set; }
        public string? BildirimAdi { get; set; }
        public string? BildirimSoyadi { get; set; }
        public string? BildirimDogumTarihi { get; set; }
        public string? BildirimTelefonu { get; set; }
        public string? BildirimAdres { get; set; }
        public string? TutanagiDuzenleyeninAdi { get; set; }
        public string? TutanagiDuzenleyeninSoyadi { get; set; }
        public string? TutanagiDuzenleyeninUnvani { get; set; }
        public string? IslemYapilanMezarlik { get; set; }
        public bool? TutanakOlusturuldu { get; set; }
        public string? Latlng1 { get; set; }
        public string? Latlng2 { get; set; }
        public string? Latlng3 { get; set; }
        public string? Latlng4 { get; set; }
        public short? Ekleyen { get; set; }
        public DateTime? EklemeTarihi { get; set; }
        public short? Guncelleyen { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public bool? Aktif { get; set; }
    }
}
