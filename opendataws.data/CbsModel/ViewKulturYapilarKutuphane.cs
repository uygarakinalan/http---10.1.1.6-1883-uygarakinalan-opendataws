using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class ViewKulturYapilarKutuphane
    {
        public int MiPrinx { get; set; }
        public string? Ad { get; set; }
        public string? Adres { get; set; }
        public int? IlceKodu { get; set; }
        public int? Tur { get; set; }
        public string? Telefon { get; set; }
        public string? Aciklama { get; set; }
        public string? MiStyle { get; set; }
        public int? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
    }
}
