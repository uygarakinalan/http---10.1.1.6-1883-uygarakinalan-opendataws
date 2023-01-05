using System;
using System.Collections.Generic;

namespace opendataws.data.MezarlikModels
{
    public partial class Menuler
    {
        public Menuler()
        {
            MenuYetkis = new HashSet<MenuYetki>();
        }

        public short Id { get; set; }
        public string? MenuAdi { get; set; }
        public int? UstMenuId { get; set; }
        public byte? MenuTip { get; set; }
        public string? Link { get; set; }
        public string? Icon { get; set; }
        public string? IconRenk { get; set; }
        public byte? SiraNo { get; set; }
        public short Ekleyen { get; set; }
        public DateTime EklemeTarihi { get; set; }
        public short? Guncelleyen { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public bool? Aktif { get; set; }

        public virtual ICollection<MenuYetki> MenuYetkis { get; set; }
    }
}
