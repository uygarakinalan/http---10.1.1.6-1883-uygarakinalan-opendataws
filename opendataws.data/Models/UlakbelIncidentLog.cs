using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class UlakbelIncidentLog
    {
        public uint Id { get; set; }
        public uint IncidentActionId { get; set; }
        public ulong? UlakbelIncidentId { get; set; }
        public string Action { get; set; } = null!;
        public string? Text { get; set; }
        public ulong PerformedAt { get; set; }
        public string Response { get; set; } = null!;
        public bool IsCompleted { get; set; }
        public string? CompletionType { get; set; }
    }
}
