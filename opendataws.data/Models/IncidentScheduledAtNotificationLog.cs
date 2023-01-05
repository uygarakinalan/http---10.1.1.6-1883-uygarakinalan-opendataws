using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class IncidentScheduledAtNotificationLog
    {
        public uint Id { get; set; }
        public uint IncidentId { get; set; }
        public ulong ScheduledAt { get; set; }
        public ulong CreatedAt { get; set; }
        public ulong? PerformedAt { get; set; }
    }
}
