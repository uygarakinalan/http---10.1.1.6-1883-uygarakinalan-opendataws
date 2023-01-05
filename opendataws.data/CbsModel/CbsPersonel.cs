using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsPersonel
    {
        public int PersonelId { get; set; }
        public string? PersonelAdisoyadi { get; set; }
        public string? PersonelSirket { get; set; }
        public int? PersonelIsegirispozisyonu { get; set; }
        public int? PersonelGorevi { get; set; }
        public string? PersonelSicilno { get; set; }
        public int? PersonelBirimId { get; set; }
        public string? PersonelTelefon { get; set; }
        public string? PersonelEmail { get; set; }
        public int? PersonelSubeId { get; set; }
        public int? PersonelPostaId { get; set; }
        public string? PersonelResim { get; set; }
        public string? PersonelTcno { get; set; }
        public DateTime? PersonelDogumtarihi { get; set; }
        public string? PersonelOgrenimdurumu { get; set; }
        public string? PersonelMedeniHal { get; set; }
        public string? PersonelKangrubu { get; set; }
        public string? PersonelAdres { get; set; }
        public int? PersonelSil { get; set; }
        public decimal? PersonelBoy { get; set; }
        public string? PersonelEhliyet { get; set; }
        public DateTime? PersonelIsebaslangictarihi { get; set; }
        public string? PersonelMezuniyetbolumu { get; set; }
        public string? PersonelHeskodu { get; set; }
    }
}
