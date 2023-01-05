using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class IncidentTimeoutFlowStage
    {
        public uint Id { get; set; }
        public uint UserId { get; set; }
        public uint IncidentId { get; set; }
        public uint Order { get; set; }
        public uint IncidentTimeoutFlowId { get; set; }
        public ulong CreatedAt { get; set; }
        public ulong? PerformedAt { get; set; }
        public ulong TimeValue { get; set; }
        public string? TimeType { get; set; }
        public ulong? IncidentActionId { get; set; }
        public ulong? CompletedAt { get; set; }
    }
}
