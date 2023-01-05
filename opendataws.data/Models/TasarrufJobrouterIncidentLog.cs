using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class TasarrufJobrouterIncidentLog
    {
        public uint Id { get; set; }
        public string Documents { get; set; } = null!;
        public string? ProcessTable { get; set; }
        public ulong? IncidentNumber { get; set; }
        public uint ProjectId { get; set; }
        public ulong CreatedAt { get; set; }
        public ulong? SignedAt { get; set; }
    }
}
