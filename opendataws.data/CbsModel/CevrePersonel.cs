using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CevrePersonel
    {
        public int PersonelId { get; set; }
        public string? PersonelAdiSoyadi { get; set; }
        public string? Tc { get; set; }
        public string? Email { get; set; }
        public string? Telefon { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public DateTime? IseBaslamaTarihi { get; set; }
        public string? PersonelGorevYeri { get; set; }
        public int? PersonelSil { get; set; }
        public string? KanGrubu { get; set; }
        public string? PersonelStatu { get; set; }
        public string? OgrenimDurumu { get; set; }
        public int? PersonelUnvani { get; set; }
        public int? PersonelBirimId { get; set; }
        public int? PersonelSubeId { get; set; }
    }
}
