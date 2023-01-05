using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsZabitaPersonel
    {
        public int PersonelId { get; set; }
        public string? PersonelTc { get; set; }
        public string? PersonelAdiSoyadi { get; set; }
        public string? PersonelAnneAdi { get; set; }
        public string? PersonelBabaAdi { get; set; }
        public string? PersonelDogumYeri { get; set; }
        public DateTime? PersonelDogumTarihi { get; set; }
        public string? PersonelOgrenimDurumu { get; set; }
        public string? PersonelMedeniHal { get; set; }
        public int? PersonelCocukSayisi { get; set; }
        public string? PersonelAdres { get; set; }
        public string? PersonelCeptelefon { get; set; }
        public string? PersonelEvtelefon { get; set; }
        public string? PersonelKanGrubu { get; set; }
        public string? PersonelSicilno { get; set; }
        public DateTime? PersonelIseBaslangicTarihi { get; set; }
        public int? PersonelKadrosu { get; set; }
        public int? PersonelBirimId { get; set; }
        public string? PersonelGorevi { get; set; }
        public string? PersonelEhliyet { get; set; }
        public string? PersonelEngelDurumu { get; set; }
        public string? PersonelPantolonBeden { get; set; }
        public string? PersonelGomlekBeden { get; set; }
        public string? PersonelAyakkabiBeden { get; set; }
        public string? PersonelKepBeden { get; set; }
        public string? PersonelPardesuBeden { get; set; }
        public decimal? PersonelBoy { get; set; }
        public decimal? PersonelKilo { get; set; }
        public string? PersonelYas { get; set; }
        public int? KayitUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public int? PersonelDurum { get; set; }
        public string? PersonelMezuniyetBolumu { get; set; }
        public string? PersonelEhliyetAdi { get; set; }
    }
}
