using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsGbbBugunNeYapiyor
    {
        public int MiPrinx { get; set; }
        public string? YapilanIs { get; set; }
        public string? YolDurumu { get; set; }
        public int? YolDurumuId { get; set; }
        public string? IsDurumu { get; set; }
        public int? IsDurumuId { get; set; }
        public DateTime? BaslangicTarihi { get; set; }
        public DateTime? BitisTarihi { get; set; }
        public int? BirimId { get; set; }
        public int? AltBirimId { get; set; }
        public string? Adres { get; set; }
        public int? IlceId { get; set; }
        public int? MahalleId { get; set; }
        public string? Csbm { get; set; }
        public string? CsbmId { get; set; }
        public int? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? MiStyle { get; set; }
    }
}
