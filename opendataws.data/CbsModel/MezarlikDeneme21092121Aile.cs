using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class MezarlikDeneme21092121Aile
    {
        public int ObsAktarimId { get; set; }
        public int? KisilerId { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public string? Cinsiyet { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string? BabaAdi { get; set; }
        public string? AnaAdi { get; set; }
        public string? TcKimlikNo { get; set; }
        public string? DogumYeri { get; set; }
        public double? MapX { get; set; }
        public double? MapY { get; set; }
        public double? MapXa { get; set; }
        public double? MapYa { get; set; }
        public string DefinYeri { get; set; } = null!;
    }
}
