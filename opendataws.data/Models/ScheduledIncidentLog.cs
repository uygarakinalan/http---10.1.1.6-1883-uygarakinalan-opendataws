using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class ScheduledIncidentLog
    {
        public uint Id { get; set; }
        public uint ScheduledIncidentId { get; set; }
        public uint? IncidentId { get; set; }
        public string Status { get; set; } = null!;
        public string? ErrorLog { get; set; }
        public ulong CreatedAt { get; set; }
    }
}
