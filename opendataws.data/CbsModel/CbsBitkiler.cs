using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsBitkiler
    {
        public CbsBitkiler()
        {
            CbsBitkiDikimAlanEnvanters = new HashSet<CbsBitkiDikimAlanEnvanter>();
            CbsBitkiEnvanters = new HashSet<CbsBitkiEnvanter>();
        }

        public int BitkiId { get; set; }
        public string? BitkiAdi { get; set; }
        public string? OzelKod1 { get; set; }
        public string? OzelKod2 { get; set; }
        public string? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? GuncelleyenUserId { get; set; }

        public virtual ICollection<CbsBitkiDikimAlanEnvanter> CbsBitkiDikimAlanEnvanters { get; set; }
        public virtual ICollection<CbsBitkiEnvanter> CbsBitkiEnvanters { get; set; }
    }
}
