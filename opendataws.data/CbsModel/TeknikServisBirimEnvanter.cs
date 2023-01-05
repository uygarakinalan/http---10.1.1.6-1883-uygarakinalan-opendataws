using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class TeknikServisBirimEnvanter
    {
        public int MiPrinx { get; set; }
        public string? TesisAdi { get; set; }
        public string? TesisSorumlusu { get; set; }
        public int? BirimId { get; set; }
        public int? AltBirimId { get; set; }
        public string? CepTelefonu { get; set; }
        public string? Mail { get; set; }
        public string? Ilce { get; set; }
        public int? IlceKodu { get; set; }
        public string? Mahalle { get; set; }
        public int? MahalleKodu { get; set; }
        public int? KaydedenUserid { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? GuncelleyenUserid { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? MiStyle { get; set; }
    }
}
