using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class IncidentAutomaticCall
    {
        public uint Id { get; set; }
        public uint IncidentId { get; set; }
        public uint? AutomaticCallLogId { get; set; }
        public uint UserId { get; set; }
        public ulong CallerNumber { get; set; }
        public ulong TargetNumber { get; set; }
        public ulong CreatedAt { get; set; }
        public string Type { get; set; } = null!;
        public string? Data { get; set; }
    }
}
