using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class ViewKamulastirmaMulkiyetEslendi
    {
        public int MulkiyetId { get; set; }
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
        public string CinsYeni { get; set; } = null!;
        public DateTime? EklenmeTarihi { get; set; }
        public DateTime? GuncellenmeTarihi { get; set; }
        public string? GuncellemeMsj { get; set; }
        public string? Aciklama { get; set; }
        public int? VerilerTamMi { get; set; }
        public string? BirimAciklama { get; set; }
        public string? EskiGeometri { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public string? KaydedenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? GuncelleyenUserId { get; set; }
        public decimal? GbbAlani { get; set; }
        public double? GbbHisseOran { get; set; }
        public string? MiStyle { get; set; }
        public int? KamulastirmaId { get; set; }
        public int? IlceKodu { get; set; }
        public int? MahalleKodu { get; set; }
        public int? TapuZeminId { get; set; }
        public string? TapuAda { get; set; }
        public string? TapuParsel { get; set; }
        public string? TapuParselId { get; set; }
        public string? TapuTapuAlan { get; set; }
        public string? TapuKadastroAlan { get; set; }
        public string? TapuMahalleAd { get; set; }
        public string? TapuMahalleId { get; set; }
        public string? TapuIlceAd { get; set; }
        public string? TapuIlceId { get; set; }
        public double? EnlemYLat { get; set; }
        public double? BoylamXLng { get; set; }
        public int? BirimId { get; set; }
        public string? KamulastirmaAciklama { get; set; }
        public int? KaydedenUserId1 { get; set; }
        public int? GuncelleyenUserId1 { get; set; }
        public int? AktifMi { get; set; }
        public int? MulkSahibiId { get; set; }
        public string? MulkSahibiAdi { get; set; }
        public int? MulkTuru { get; set; }
        public string? MulkTurAdi { get; set; }
        public int? StyleTur { get; set; }
    }
}
