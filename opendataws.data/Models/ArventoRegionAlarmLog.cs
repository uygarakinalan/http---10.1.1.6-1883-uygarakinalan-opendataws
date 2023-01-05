using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class ArventoRegionAlarmLog
    {
        public uint Id { get; set; }
        public uint IncidentId { get; set; }
        public uint NodeId { get; set; }
        public uint RegionId { get; set; }
        public ulong CreatedAt { get; set; }
        public string? Status { get; set; }
        public ulong? JobPerformedAt { get; set; }
        public ulong? AlarmCreatedAt { get; set; }
    }
}
