using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class IncidentCompletionReason
    {
        public uint Id { get; set; }
        public string Name { get; set; } = null!;
        public string? CompletionType { get; set; }
        public ulong? DeletedAt { get; set; }
    }
}
