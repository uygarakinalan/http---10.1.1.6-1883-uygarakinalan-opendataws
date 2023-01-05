using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class SmartResponseFlow
    {
        public uint Id { get; set; }
        public string Title { get; set; } = null!;
        public string FlowChartData { get; set; } = null!;
        public string? Keywords { get; set; }
        public uint? IncidentSourceId { get; set; }
        public sbyte? Priority { get; set; }
        public ulong CreatedAt { get; set; }
        public string? Trigger { get; set; }
        public string? RegexString { get; set; }
        public bool? IsActive { get; set; }
        public int LastTimeoutMessage { get; set; }
        public ulong? DeletedAt { get; set; }
        public string? CustomAccountIds { get; set; }
    }
}
