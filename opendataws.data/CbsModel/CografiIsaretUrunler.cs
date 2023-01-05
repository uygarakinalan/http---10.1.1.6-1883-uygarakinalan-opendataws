using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CografiIsaretUrunler
    {
        public int Id { get; set; }
        public string? UrunAdi { get; set; }
        public DateTime? BasvuruTarihi { get; set; }
        public DateTime? IlanTarihi { get; set; }
        public int BasvuruYapanKurumId { get; set; }
        public DateTime? TescilTarihi { get; set; }
        public string? Aciklama { get; set; }
        public int? DurumId { get; set; }
        public string? BasvuruYapanKurumAdi { get; set; }
        public string? DurumAciklama { get; set; }
        public string? TescilNumarasi { get; set; }
        public int? TescilTurId { get; set; }
        public string? TescilTurAdi { get; set; }
    }
}
