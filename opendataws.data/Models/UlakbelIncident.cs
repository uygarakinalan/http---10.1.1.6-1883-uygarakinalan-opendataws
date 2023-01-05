using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class UlakbelIncident
    {
        public uint Id { get; set; }
        public ulong RemoteId { get; set; }
        public uint RemoteNumber { get; set; }
        public string Data { get; set; } = null!;
        public ulong ImportedAt { get; set; }
        public string Files { get; set; } = null!;
        public ulong CreatedIncidentNumber { get; set; }
        public bool IsCompleted { get; set; }
        public string? Type { get; set; }
        public uint? IncidentSourceId { get; set; }
    }
}
