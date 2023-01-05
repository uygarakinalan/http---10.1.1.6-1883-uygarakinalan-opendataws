using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class IlceToplanmaAlani
    {
        public string? IlceAdi { get; set; }
        public double? IlceKodu { get; set; }
        public double? IlKodu { get; set; }
        public string? IlAdi { get; set; }
        public int? IlceMerkezNufusu { get; set; }
        public int? AsgariIhtiyacDuyulanAlan { get; set; }
        public int? _2021OncesiToplanmaAlaniSayisi { get; set; }
        public int? _2021OncesiToplanmaAlaniM2 { get; set; }
        public double? _2021OncesiKisiBasiDusenAlanM2 { get; set; }
        public string? _2021OncesiIhtiyaciKarsilamaOrani { get; set; }
        public short? MevcutDurumToplanmaAlaniSayisi { get; set; }
        public int? MevcutDurumToplanmaAlaniM2 { get; set; }
        public double? MevcutDurumKisiBasiDusenAlanM2 { get; set; }
        public string? MevcutDurumIhtiyaciKarsilamaOrani { get; set; }
        public string? MiStyle { get; set; }
        public int MiPrinx { get; set; }
    }
}
