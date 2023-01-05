using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class IncidentLog
    {
        public uint Id { get; set; }
        public uint IncidentId { get; set; }
        public int UserId { get; set; }
        public string Attribute { get; set; } = null!;
        public string? OldValue { get; set; }
        public string? NewValue { get; set; }
        public string? IpAddress { get; set; }
        public ulong CreatedAt { get; set; }
    }
}
