using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class OgrenciSorgulamaLog
    {
        public int Id { get; set; }
        public int? KullaniciId { get; set; }
        public string? KullaniciAdi { get; set; }
        public DateTime? SorgulamaTarihi { get; set; }
        public string? SorgulananTc { get; set; }
        public string? KullaniciIp { get; set; }
    }
}
