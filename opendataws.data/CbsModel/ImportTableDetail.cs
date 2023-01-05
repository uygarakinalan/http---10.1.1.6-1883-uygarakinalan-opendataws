using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class ImportTableDetail
    {
        public int Id { get; set; }
        public string? Ip { get; set; }
        public string? KullaniciAdi { get; set; }
        public DateTime? IslemTarihi { get; set; }
        public string? DosyaAdi { get; set; }
        public string? TabloAdi { get; set; }
        public string? Projeksiyon { get; set; }
        public string? VerininGonderildigiYer { get; set; }
        public string? DosyaTuru { get; set; }
    }
}
