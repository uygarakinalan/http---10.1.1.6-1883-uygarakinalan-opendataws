using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class IbbIncidentLog
    {
        public uint Id { get; set; }
        public uint IncidentActionId { get; set; }
        public string IbbIncidentNumber { get; set; } = null!;
        public string? Text { get; set; }
        public string Action { get; set; } = null!;
        public ulong PerformedAt { get; set; }
        public string? Response { get; set; }
        public sbyte IsCompleted { get; set; }
        public string CompletionType { get; set; } = null!;
        public string? Request { get; set; }
    }
}
