using System;
using System.Collections.Generic;

namespace opendataws.data.MezarlikModels
{
    public partial class ObsAktarim
    {
        public ObsAktarim()
        {
            Kisilers = new HashSet<Kisiler>();
        }

        public int Id { get; set; }
        public string? FormNo { get; set; }
        public string? TcKimlikNo { get; set; }
        public string? Cinsiyet { get; set; }
        public string? Uyruk { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public string? BabaAdi { get; set; }
        public string? AnaAdi { get; set; }
        public string? DogumYeri { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string? OlumAdresKoy { get; set; }
        public string? KurumAdi { get; set; }
        public string? NufusIl { get; set; }
        public string? NufusIlce { get; set; }
        public string? CiltNo { get; set; }
        public string? AileNo { get; set; }
        public string? BireyNo { get; set; }
        public string? MedeniHal { get; set; }
        public string? Meslek { get; set; }
        public string? Din { get; set; }
        public DateTime? OlumTarihi { get; set; }
        public string? MernisIlKodu { get; set; }
        public string? MernisIlceKodu { get; set; }
        public string? MernisKoyMahalle { get; set; }
        public string? MernisCaddeSokak { get; set; }
        public string? MernisSite { get; set; }
        public string? MernisDisKapi { get; set; }
        public string? MernisIcKapi { get; set; }
        public string? BilgiVerenTc { get; set; }
        public string? BilgiVerenAdSoyad { get; set; }
        public string? BilgiVerenDogumTarih { get; set; }
        public string? BilgiVerenYakinlik { get; set; }
        public string? BilgiVerenAdres { get; set; }
        public string? BilgiVerenTelefon { get; set; }
        public string? OluDogum { get; set; }
        public string? BebekOlum { get; set; }
        public string? KadinOlum { get; set; }
        public string? DoktorKurumAdi { get; set; }
        public string? HekimAdSoyad { get; set; }
        public DateTime? RaporTarih { get; set; }
        public bool? Aktarildi { get; set; }
        public DateTime? AktarimTarihi { get; set; }
        public short? AktaranKullaniciId { get; set; }
        public bool? Arandi { get; set; }
        public short? ArayanKullaniciId { get; set; }
        public DateTime? AramaTarihi { get; set; }
        public bool? OnKayit { get; set; }
        public short? Ekleyen { get; set; }
        public DateTime? EklemeTarihi { get; set; }
        public short? Guncelleyen { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public bool? Aktif { get; set; }

        public virtual ICollection<Kisiler> Kisilers { get; set; }
    }
}
