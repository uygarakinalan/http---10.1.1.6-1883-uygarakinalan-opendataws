using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class ViewHalGatem
    {
        public int? EslemeId { get; set; }
        public int? ZeminId { get; set; }
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
        public int? MahalleKodu { get; set; }
        public int? IlceKodu { get; set; }
        public DateTime? TeminatBaslangicTarihi { get; set; }
        public DateTime? TeminatBitisTarihi { get; set; }
        public int? TeminatSureliMi { get; set; }
        public string? TeminatAciklama { get; set; }
        public string TeminatSureliMi1 { get; set; } = null!;
    }
}
