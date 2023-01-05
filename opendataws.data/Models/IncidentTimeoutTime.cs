using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class IncidentTimeoutTime
    {
        public uint Id { get; set; }
        public uint IncidentId { get; set; }
        public ulong TimeoutSeconds { get; set; }
        public string Model { get; set; } = null!;
        public uint? ModelId { get; set; }
        public ulong CreatedAt { get; set; }
    }
}
