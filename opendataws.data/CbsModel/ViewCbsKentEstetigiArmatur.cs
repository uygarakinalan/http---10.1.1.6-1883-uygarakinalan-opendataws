using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class ViewCbsKentEstetigiArmatur
    {
        public int MiPrinx { get; set; }
        public int? ArmaturId { get; set; }
        public int? ArmaturAdedi { get; set; }
        public string? ArmaturAdresi { get; set; }
        public int? IlceKodu { get; set; }
        public int? MahalleKodu { get; set; }
        public string? Ilce { get; set; }
        public string? Mahalle { get; set; }
        public string? OzelKod1 { get; set; }
        public int? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? MiStyle { get; set; }
        public string? ArmaturAdi { get; set; }
        public string? IlceAdi { get; set; }
        public string? MahalleAdi { get; set; }
    }
}
