using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class ViewItfaiyeKurtarmaNoktalari
    {
        public int Id { get; set; }
        public string? BildirilenAdres { get; set; }
        public DateTime? BildirimTarihi { get; set; }
        public string? BildirenKisiAdi { get; set; }
        public string? BildirenTel { get; set; }
        public string? TuruTxt { get; set; }
        public string? IhbarAciklamasi { get; set; }
        public int? Turu { get; set; }
        public string? MahalleAdi { get; set; }
        public string? IlceAdi { get; set; }
        public string? KurtarmaTuruTxt { get; set; }
        public int? RaporUlasmadk { get; set; }
        public int? RaporMudahaledk { get; set; }
        public string IhbarDurum { get; set; } = null!;
        public string SubeAdi { get; set; } = null!;
        public string PostaAdi { get; set; } = null!;
    }
}
