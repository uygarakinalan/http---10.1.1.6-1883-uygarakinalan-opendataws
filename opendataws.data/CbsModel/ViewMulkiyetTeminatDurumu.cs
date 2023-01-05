using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class ViewMulkiyetTeminatDurumu
    {
        public string? MulkTeminatDurumu { get; set; }
        public string MulkTeminatDurumuId { get; set; } = null!;
        public string? KimlikNo { get; set; }
        public int? KisiId { get; set; }
        public string? KisiUnvani { get; set; }
        public string? KisiTipi { get; set; }
        public string? Ada { get; set; }
        public string? Nitelik { get; set; }
        public string? Mevkii { get; set; }
        public string? Pafta { get; set; }
        public string? ParselId { get; set; }
        public string? Durum { get; set; }
        public string? TapuAlan { get; set; }
        public string? KadastroAlan { get; set; }
        public string? ZeminId { get; set; }
        public string? ZeminTip { get; set; }
        public string? ParselNo { get; set; }
        public string? CiltNo { get; set; }
        public string? SayfaNo { get; set; }
        public string? Il { get; set; }
        public string? IlId { get; set; }
        public string? Ilce { get; set; }
        public string? IlceId { get; set; }
        public string? MahalleId { get; set; }
        public string? Mahalle { get; set; }
        public string? Cins { get; set; }
        public string? Aciklama { get; set; }
        public string? BirimAciklama { get; set; }
        public int? MulkTuru { get; set; }
        public decimal? GbbAlani { get; set; }
        public double? GbbHisseOran { get; set; }
        public string? MulkSatisDurumu { get; set; }
        public decimal? ArsaMetrekareDegeri { get; set; }
        public decimal? IzDegeri { get; set; }
        public decimal? MaaliyetDegeri { get; set; }
        public decimal? BinaDegeri { get; set; }
        public string? ImarDurumu { get; set; }
    }
}
