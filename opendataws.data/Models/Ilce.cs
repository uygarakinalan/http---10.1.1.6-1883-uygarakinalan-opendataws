using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class Ilce
    {
        public int IlceId { get; set; }
        public string IlceTitle { get; set; } = null!;
        public int IlceKey { get; set; }
        public int IlceSehirkey { get; set; }
        public ulong? ControlledAt { get; set; }
    }
}
