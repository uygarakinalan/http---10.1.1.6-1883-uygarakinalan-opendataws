using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class ViewCbsKiraSersiviDenetimDetay
    {
        public int DenetimDetayId { get; set; }
        public int? KiraDenetimId { get; set; }
        public int? DenetimTuru { get; set; }
        public DateTime? DenetimTarihi { get; set; }
        public int? KiraServisiSiraNo { get; set; }
        public int? DenetimKonusuId { get; set; }
        public string? Konu { get; set; }
        public string? DenetimKonusuDurumu { get; set; }
    }
}
