using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class GidaYardimCalisma
    {
        public int MiPrinx { get; set; }
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
        public string MiStyle { get; set; } = null!;
    }
}
