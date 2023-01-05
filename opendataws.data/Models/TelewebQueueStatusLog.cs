using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class TelewebQueueStatusLog
    {
        public uint Id { get; set; }
        public uint Extension { get; set; }
        public uint Queue { get; set; }
        public uint UserId { get; set; }
        public string Status { get; set; } = null!;
        public ulong PerformedAt { get; set; }
    }
}
