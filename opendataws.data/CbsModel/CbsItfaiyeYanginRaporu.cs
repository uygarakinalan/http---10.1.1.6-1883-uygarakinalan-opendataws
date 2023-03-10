using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsItfaiyeYanginRaporu
    {
        public int Id { get; set; }
        public DateTime? OlayTarihi { get; set; }
        public int? KayitNo { get; set; }
        public DateTime? RaporKayitTarihi { get; set; }
        public string? BildirimSiraNo { get; set; }
        public DateTime? BildirimTarihi { get; set; }
        public string? BildirenKisiAdi { get; set; }
        public string? BildirenTel { get; set; }
        public int? BildirimAlanPersonel { get; set; }
        public string? BildirilenAdres { get; set; }
        public string? DogruAdres { get; set; }
        public int? YanginTuru { get; set; }
        public int? BinaYapimsekli { get; set; }
        public int? BinaKullanimSekli { get; set; }
        public string? Sahibi { get; set; }
        public string? KiraciVeyaKullanan { get; set; }
        public int? GidenEkibinAmiri { get; set; }
        public int? Onaylayan { get; set; }
        public int? GidenEkibinAracSayisi { get; set; }
        /// <summary>
        /// PERSONEL ID LERI ARALARINDA - ISARETI ILE AYRILIYOR 10-12-3-4 VB.
        /// </summary>
        public string? GidenEkibinPersonel { get; set; }
        public DateTime? GidenEkibinCikistarihi { get; set; }
        public DateTime? GidenEkibinVaristarihi { get; set; }
        public DateTime? GidenEkibinAyrilistarihi { get; set; }
        public DateTime? GidenEkibinDonustarihi { get; set; }
        public DateTime? ElektrikArizaGelistarihi { get; set; }
        public DateTime? AmbulansGelisTarihi { get; set; }
        public DateTime? DogalgazEkibiGelisTarihi { get; set; }
        public DateTime? YEkipCikistarihi { get; set; }
        public int? YEkipAracsayisi { get; set; }
        /// <summary>
        /// PERSONEL ID LERI ARALARINDA - ISARETI ILE AYRILIYOR 10-12-3-4 VB.
        /// </summary>
        public string? YEkipPersonel { get; set; }
        public int? YEkipAmiri { get; set; }
        public int? SondurmeTuru { get; set; }
        public int? SondurmeSuMiktari { get; set; }
        public int? SondurmeKopukMiktari { get; set; }
        public int? SondurmeKktMiktari { get; set; }
        public string? HasarDurumu { get; set; }
        public int? YanginNedeni { get; set; }
        public string? YanginNedeniAciklama { get; set; }
        public string? SigortaSirketAdi { get; set; }
        public string? SigortaBedeli { get; set; }
        public string? AracGerecKaybi { get; set; }
        public string? YanginYeriTeslimEdilen { get; set; }
        public int? OluItfaiyeciSayisi { get; set; }
        public int? YaraliItfaiyeciSayisi { get; set; }
        public int? OluHalkSayisi { get; set; }
        public int? YaraliHalkSayisi { get; set; }
        public int? OluHayvanSayisi { get; set; }
        public int? YaraliHayvanSayisi { get; set; }
        public int? GidenSubeId { get; set; }
        public string? GidenEkipAdi { get; set; }
        public int? YanginNobetciCavusu { get; set; }
        public int? YanginNobetciAmiri { get; set; }
        public string? KayitUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        /// <summary>
        /// 0 = YANGIN , 1 = KURTARMA
        /// </summary>
        public int? Turu { get; set; }
        public string? IhbarAciklamasi { get; set; }
        /// <summary>
        /// 0 = TASLAK , 1 = GUNCELLENDI
        /// </summary>
        public int? Durum { get; set; }
        public int? BinaNo { get; set; }
        public int? KurtarmaTuru { get; set; }
        /// <summary>
        /// 1 = asilsiz ihbar , 0 = asılsız degil
        /// </summary>
        public int? AsilsizIhbar { get; set; }
        public string? MahalleAdi { get; set; }
        public string? CaddeAdi { get; set; }
        public string? IlceAdi { get; set; }
        public int? GidenPostaId { get; set; }
        public string? MiStyle { get; set; }
        public int? BildirimTuru { get; set; }
        public int? OluKadinSayisi { get; set; }
        public int? OluErkekSayisi { get; set; }
        public int? OluCocukSayisi { get; set; }
        public int? YaraliKadinSayisi { get; set; }
        public int? YaraliErkekSayisi { get; set; }
        public int? YaraliCocukSayisi { get; set; }
        public string? MahalleId { get; set; }
        public string? IlceId { get; set; }
        public string? CsbmId { get; set; }
        public int? DogalAfetTuru { get; set; }
        public int? SondurmeKopukAff { get; set; }
        public int? SondurmeKopukAlkol { get; set; }
        public int? SondurmeKopukSentetik { get; set; }
        public int? SolunumSeti { get; set; }
        public int? PersonelSayisi { get; set; }
        public int? YrdEkipPersonelSayisi { get; set; }
        public string? KurtarmaSekli { get; set; }
        public string? YanginBaslangicNedeni { get; set; }
        public DateTime? RaporKayitNoOlusturmaTarihi { get; set; }
        public int? RaporKayitNoOlusturan { get; set; }
        public string? KiraciVeyaKullananTc { get; set; }
        public DateTime? KiraciVeyaKullananDogumTarihi { get; set; }
        public int? KiraciVeyaKullananUyruk { get; set; }
        public string? KiraciVeyaKullananUyrukAciklama { get; set; }
        public string? SahibiTc { get; set; }
        public DateTime? SahibiDogumTarihi { get; set; }
        public int? SahibiUyruk { get; set; }
        public string? SahibiUyrukAciklama { get; set; }
        public int? EngelliSayisi { get; set; }
        public int? KayitSilindi { get; set; }
        public int? KurtarmaTuruCinsi { get; set; }
        public string? OlayinGorulduguDurum { get; set; }
    }
}
