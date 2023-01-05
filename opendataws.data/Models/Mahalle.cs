using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class Mahalle
    {
        public int MahalleId { get; set; }
        public string MahalleTitle { get; set; } = null!;
        public int MahalleKey { get; set; }
        public int MahalleIlcekey { get; set; }
        public bool? Aktif { get; set; }
        public ulong? ControlledAt { get; set; }
    }
}
