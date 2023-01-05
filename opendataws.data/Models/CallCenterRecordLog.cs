using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class CallCenterRecordLog
    {
        public uint Id { get; set; }
        public uint? UserId { get; set; }
        public string? IpAddress { get; set; }
        public string? RecordUsageType { get; set; }
        public string? ReferenceId { get; set; }
        public string? Source { get; set; }
        public ulong CreatedAt { get; set; }
        public string? FromPage { get; set; }
    }
}
