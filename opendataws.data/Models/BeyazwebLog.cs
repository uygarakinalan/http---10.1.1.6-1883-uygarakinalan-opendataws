using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class BeyazwebLog
    {
        public uint Id { get; set; }
        public uint IncidentId { get; set; }
        public string Request { get; set; } = null!;
        public string? Response { get; set; }
        public ulong CompletedAt { get; set; }
    }
}
