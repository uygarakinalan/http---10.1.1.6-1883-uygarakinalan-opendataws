using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class NviMaksDegisenler
    {
        public int MiPrinx { get; set; }
        public int? Kimlikno { get; set; }
        public string? MaksKatmanAdi { get; set; }
        public string? VeritabaniTabloAdi { get; set; }
        public string? IliskiAlanAdi { get; set; }
        public int? IliskiKimlikno { get; set; }
        public string? Islem { get; set; }
        public int? GeometryDurum { get; set; }
        public int? AktarimDurumu { get; set; }
        public int? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? MiStyle { get; set; }
    }
}
