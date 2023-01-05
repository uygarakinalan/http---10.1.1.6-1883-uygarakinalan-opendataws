using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class ViewKamulastirmaTahsisAlinan
    {
        public string TarihKontrol { get; set; } = null!;
        public int MiPrinx { get; set; }
        public string? Ilce { get; set; }
        public string? Mahalle { get; set; }
        public decimal? Yuzolcum { get; set; }
        public string? TahsisSuresi { get; set; }
        public string? TahsisAlinanEdilenKurum { get; set; }
        public string? TahsisAmaci { get; set; }
        public DateTime? TahsisBaslangicTarihi { get; set; }
        public DateTime? TahsisBitisTarihi { get; set; }
        public DateTime? OnTahsisTarihi { get; set; }
        public DateTime? KesinTahsisTarihi { get; set; }
        public string? TapuAda { get; set; }
        public string? TapuParsel { get; set; }
        public string? Tur { get; set; }
        public int? TurKodu { get; set; }
        public string? MiStyle { get; set; }
    }
}
