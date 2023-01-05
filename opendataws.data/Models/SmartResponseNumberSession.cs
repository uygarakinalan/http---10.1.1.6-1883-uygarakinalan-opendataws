using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class SmartResponseNumberSession
    {
        public uint Id { get; set; }
        public ulong PhoneNumber { get; set; }
        public string Source { get; set; } = null!;
        public uint? SmartResponseFlowId { get; set; }
        public string? LastStage { get; set; }
        public ulong CreatedAt { get; set; }
        public ulong UpdatedAt { get; set; }
        public ulong? ExpiredAt { get; set; }
    }
}
