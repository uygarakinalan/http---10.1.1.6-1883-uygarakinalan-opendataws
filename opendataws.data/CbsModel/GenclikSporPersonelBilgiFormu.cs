using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class GenclikSporPersonelBilgiFormu
    {
        public int PersonelId { get; set; }
        public string? PersonelTcNo { get; set; }
        public string? PersonelAdiSoyadi { get; set; }
        public string? PersonelDogumYeri { get; set; }
        public DateTime? PersonelDogumTarihi { get; set; }
        public string? PersonelTelefon { get; set; }
        public string? PersonelEmail { get; set; }
        public string? PersonelAdres { get; set; }
        public string? PersonelCinsiyeti { get; set; }
        public string? PersonelMedeniHali { get; set; }
        public string? PersonelKanGrubu { get; set; }
        public string? PersonelOgrenimDurumu { get; set; }
        public string? PersonelMezunOlduguOkul { get; set; }
        public string? PersonelMezunOlduguBolum { get; set; }
        public string? PersonelAldigiBelgeler { get; set; }
        public DateTime? PersonelIseBaslangicTarihi { get; set; }
        public int? PersonelKadroId { get; set; }
        public int? PersonelCalistigiTesisId { get; set; }
        public string? PersonelGorevi { get; set; }
        public string? PersonelAcildurumYakiniAdisoyadi { get; set; }
        public string? PersonelAcildurumYakiniTelefonu { get; set; }
        public int? MiPrinx { get; set; }
        public int? KayitUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public int? PersonelDurum { get; set; }
        public int? PersonelSil { get; set; }
        public int? PersonelBagliOlduguMudurluk { get; set; }
    }
}
