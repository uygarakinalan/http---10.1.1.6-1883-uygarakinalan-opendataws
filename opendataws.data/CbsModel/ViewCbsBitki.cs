using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class ViewCbsBitki
    {
        public int? FirmaId { get; set; }
        public int? BitkiSayisi { get; set; }
        public int? BitkiId { get; set; }
        public int? PersonelId { get; set; }
        public int? DosyaKodu { get; set; }
        public DateTime? GelenBitkiTarihi { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? GuncelleyenUserid { get; set; }
        public string? KaydedenUserId { get; set; }
        public string? BitkiAdi { get; set; }
        public string? FidanlikBolumleri { get; set; }
        public string? FirmaAdi { get; set; }
        public int? FidanlikBolumleriId { get; set; }
        public string? BitkiOzelKod1 { get; set; }
        public string? BitkiOzelKod2 { get; set; }
    }
}
