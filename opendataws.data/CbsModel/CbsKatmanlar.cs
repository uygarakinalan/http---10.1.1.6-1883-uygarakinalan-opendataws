using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsKatmanlar
    {
        public int KatmanId { get; set; }
        public string? KatmanDegisken { get; set; }
        public string? KatmanAdi { get; set; }
        public string? KatmanText { get; set; }
        public int? KatmanSira { get; set; }
        public string? KatmanIcon { get; set; }
        /// <summary>
        /// 0 = root katman , deger varsa ana katmanın id sidir
        /// </summary>
        public int? KatmanRootId { get; set; }
        public int? Katmanzindex { get; set; }
        public string? KatmanStyle { get; set; }
        public string? GeoserverUrl { get; set; }
        /// <summary>
        /// 0 = aktif 1 = pasif
        /// </summary>
        public int? KatmanDurum { get; set; }
        public string? KatmanTuru { get; set; }
        public string? KatmanOpacity { get; set; }
        public string? CqlFilter { get; set; }
        public string? KatmanMinzoom { get; set; }
        public string? KatmanMaxzoom { get; set; }
        /// <summary>
        /// 0=cache pasif 1 = cache aktif
        /// </summary>
        public int? CacheDurumu { get; set; }
        public string? WmsVersion { get; set; }
        public string? WfsVersion { get; set; }
        public string? KatmanIconRenk { get; set; }
        public int? KatmanAktiflik { get; set; }
        public int? KaydedenUserid { get; set; }
        public int? GuncelleyenUserid { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
    }
}
