using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class SmartResponseNumberStage
    {
        public uint Id { get; set; }
        public string Stage { get; set; } = null!;
        public uint SmartResponseNumberSessionId { get; set; }
        public uint? CustomsMessageId { get; set; }
        public string? Answer { get; set; }
        public ulong CreatedAt { get; set; }
    }
}
