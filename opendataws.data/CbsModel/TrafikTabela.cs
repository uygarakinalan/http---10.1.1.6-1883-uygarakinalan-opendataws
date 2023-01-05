using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class TrafikTabela
    {
        public int? KayitNo { get; set; }
        public int? SiraNo { get; set; }
        public int? NoktaAdi { get; set; }
        public string? Ilcesi { get; set; }
        public string? MahalleAdi { get; set; }
        public string? YolunAdi { get; set; }
        public string? YolunTuru { get; set; }
        public int? Km { get; set; }
        public int? Metraj { get; set; }
        public string? YolunBaslangici { get; set; }
        public string? YolunBitisi { get; set; }
        public string? Bulvar { get; set; }
        public string? Cadde { get; set; }
        public string? Sokak { get; set; }
        public string? KavsakAdi { get; set; }
        public string? OrtaRefuj { get; set; }
        public string? Sol { get; set; }
        public string? Sag { get; set; }
        public string? LevhaKodu { get; set; }
        public string? LevhaTanimi { get; set; }
        public string? LevhaTipi { get; set; }
        public int? LevhaSayisi { get; set; }
        public string? LevhaGeometrisi { get; set; }
        public DateTime? MontajTarihi { get; set; }
        public DateTime? DeMontajTarihi { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public string? Fotograf { get; set; }
        public string? ResimAdres { get; set; }
        public string? Aciklama { get; set; }
        public int MiPrinx { get; set; }
        public string? DirekTipi { get; set; }
        public string? CaddeSokak { get; set; }
        public string? MiStyle { get; set; }
    }
}
