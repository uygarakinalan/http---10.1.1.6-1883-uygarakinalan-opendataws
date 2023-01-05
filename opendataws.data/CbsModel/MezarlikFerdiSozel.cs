using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class MezarlikFerdiSozel
    {
        public int Id { get; set; }
        public int? ObsAktarimId { get; set; }
        public byte? DefinYeri { get; set; }
        public byte? Durum { get; set; }
        public string? OlumSebebi { get; set; }
        public bool? Onay { get; set; }
        public int? MahalleId { get; set; }
        public short? IlceId { get; set; }
        public short? IlId { get; set; }
        public int? UlkeId { get; set; }
        public byte? IslemYapilanMezarlik { get; set; }
        public byte? MezarliklarId { get; set; }
        public int? AileMezarId { get; set; }
        public int? TekilMezarId { get; set; }
        public string? Aciklama { get; set; }
        public DateTime? DefinTarihi { get; set; }
        public int? UmumiSiraNo { get; set; }
        public bool? WebSitesineAktarildi { get; set; }
        public short? Ekleyen { get; set; }
        public DateTime? EklemeTarihi { get; set; }
        public short? Guncelleyen { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public bool? Aktif { get; set; }
        public string? USiraNo { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public string? NoYokIsi { get; set; }
        public string? Durumu { get; set; }
        public string? Fotograf { get; set; }
        public string? MiStyle { get; set; }
        public int MiPrinx { get; set; }
    }
}
