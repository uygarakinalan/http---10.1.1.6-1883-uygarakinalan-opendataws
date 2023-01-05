using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class AutomaticCallLog
    {
        public uint Id { get; set; }
        public string Status { get; set; } = null!;
        public ulong CreatedAt { get; set; }
        public ulong? UpdatedAt { get; set; }
        public string TargetType { get; set; } = null!;
        public uint TargetTableId { get; set; }
        public string? Uid { get; set; }
        public int? Extension { get; set; }
    }
}
