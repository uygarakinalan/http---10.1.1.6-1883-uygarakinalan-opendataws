using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class GaskiMadenOcagi
    {
        public int MiPrinx { get; set; }
        public string? Adi { get; set; }
        public string? Ili { get; set; }
        public string? Ilcesi { get; set; }
        public string? Mahallesi { get; set; }
        public string? FirmaAdi { get; set; }
        public string? FirmaTelefonu { get; set; }
        public string? Kapasite { get; set; }
        public double? KoordinatX { get; set; }
        public double? KoordinatY { get; set; }
        public string? Aciklama { get; set; }
        public string? IlceKodu { get; set; }
        public string? MahalleKodu { get; set; }
        public string? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public string? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? MiStyle { get; set; }
        public int? EslemeId { get; set; }
    }
}
