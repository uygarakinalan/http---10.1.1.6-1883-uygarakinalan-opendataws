using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsTapuLog
    {
        public int Id { get; set; }
        public int KullaniciId { get; set; }
        public DateTime SorgulamaTarihi { get; set; }
        public string Ip { get; set; } = null!;
        public int ZeminId { get; set; }
        public int Ada { get; set; }
        public int Parsel { get; set; }
        public int MahalleNo { get; set; }
        public string? MahalleAdi { get; set; }
        public string Tur { get; set; } = null!;

        public virtual Kullanicilar Kullanici { get; set; } = null!;
    }
}
