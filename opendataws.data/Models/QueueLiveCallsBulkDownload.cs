using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class QueueLiveCallsBulkDownload
    {
        public uint Id { get; set; }
        public string RequestObject { get; set; } = null!;
        public string? IpAddress { get; set; }
        public string? UserAgent { get; set; }
        public string? LocalName { get; set; }
        public uint UserId { get; set; }
        public ulong? TotalCount { get; set; }
        public int? TotalPage { get; set; }
        public int? CurrentPage { get; set; }
        public ulong StartTime { get; set; }
        public ulong? EndTime { get; set; }
        public ulong CreatedAt { get; set; }
        public ulong? DeletedAt { get; set; }
    }
}
