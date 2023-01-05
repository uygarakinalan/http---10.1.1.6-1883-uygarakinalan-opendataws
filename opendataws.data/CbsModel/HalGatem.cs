using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class HalGatem
    {
        public int? EslemeId { get; set; }
        public string? IsyeriNo { get; set; }
        public string? AdiSoyadi { get; set; }
        public string? OrtaklikGizli { get; set; }
        public string? TcKimlikGizli { get; set; }
        public string? TcNo { get; set; }
        public string? Sifati { get; set; }
        public string? Email { get; set; }
        public string? CepTelefonu { get; set; }
        public string? PaftaNo { get; set; }
        public int? ParselNo { get; set; }
        public int? AdaNo { get; set; }
        public string? FotografNo { get; set; }
        public string? Adi { get; set; }
        public string? Unvani { get; set; }
        public string? Ortaklik { get; set; }
        public string? MiStyle { get; set; }
        public int MiPrinx { get; set; }
        public int? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public int? IlceKodu { get; set; }
        public int? MahalleKodu { get; set; }
        public int? ZeminId { get; set; }
        public DateTime? TeminatBaslangicTarihi { get; set; }
        public DateTime? TeminatBitisTarihi { get; set; }
        public int? TeminatSureliMi { get; set; }
        public string? TeminatAciklama { get; set; }
        public string? EskiTc { get; set; }
    }
}
