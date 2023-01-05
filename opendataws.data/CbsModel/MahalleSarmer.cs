using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class MahalleSarmer
    {
        public int Id { get; set; }
        public string? MahalleKodu { get; set; }
        public string? MahalleAdi { get; set; }
        public int? IlceId { get; set; }
        public int? Hane { get; set; }
        public int? Durumu { get; set; }
        public DateTime? BasTarih { get; set; }
        public DateTime? BitTarih { get; set; }
        public int? MaksMahKod { get; set; }
        public int? GisIlceSinirlarKod { get; set; }
    }
}
