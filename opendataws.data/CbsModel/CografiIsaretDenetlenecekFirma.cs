using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CografiIsaretDenetlenecekFirma
    {
        public int Id { get; set; }
        public string? FirmaAdi { get; set; }
        public string? FirmaAdresi { get; set; }
        public string? FirmaTelefon { get; set; }
        public int? UrunId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }
        public int? KaydedenUserid { get; set; }
    }
}
