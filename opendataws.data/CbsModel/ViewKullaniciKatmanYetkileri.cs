using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class ViewKullaniciKatmanYetkileri
    {
        public int? KatmanId { get; set; }
        public int? KullaniciId { get; set; }
        public string? KatmanAdi { get; set; }
        public string? KulAdi { get; set; }
    }
}
