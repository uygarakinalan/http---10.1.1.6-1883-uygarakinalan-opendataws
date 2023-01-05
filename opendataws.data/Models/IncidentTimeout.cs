using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class IncidentTimeout
    {
        public uint Id { get; set; }
        public string Model { get; set; } = null!;
        public ulong Value { get; set; }
        public string Type { get; set; } = null!;
        public uint ModelId { get; set; }
        public ulong Seconds { get; set; }
    }
}
