using System;
using System.Collections.Generic;

namespace opendataws.data.MezarlikModels
{
    public partial class Kisiler
    {
        public Kisiler()
        {
            KisiYakinlaris = new HashSet<KisiYakinlari>();
            ObsHarita = new HashSet<ObsHaritum>();
            OnayKaldirmaNedenleris = new HashSet<OnayKaldirmaNedenleri>();
        }

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
        public int? OlumSebebiId { get; set; }
        public short? Ekleyen { get; set; }
        public DateTime? EklemeTarihi { get; set; }
        public short? Guncelleyen { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public bool? Aktif { get; set; }

        public virtual AileMezarlik? AileMezar { get; set; }
        public virtual Iller? Il { get; set; }
        public virtual Ilceler? Ilce { get; set; }
        public virtual Mezarliklar? Mezarliklar { get; set; }
        public virtual ObsAktarim? ObsAktarim { get; set; }
        public virtual OlumSebepleri? OlumSebebiNavigation { get; set; }
        public virtual TekilMezarlik? TekilMezar { get; set; }
        public virtual Ulkeler? Ulke { get; set; }
        public virtual ICollection<KisiYakinlari> KisiYakinlaris { get; set; }
        public virtual ICollection<ObsHaritum> ObsHarita { get; set; }
        public virtual ICollection<OnayKaldirmaNedenleri> OnayKaldirmaNedenleris { get; set; }
    }
}
