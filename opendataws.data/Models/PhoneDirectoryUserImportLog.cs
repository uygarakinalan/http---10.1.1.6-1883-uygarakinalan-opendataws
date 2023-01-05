using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class PhoneDirectoryUserImportLog
    {
        public uint Id { get; set; }
        public ulong UserId { get; set; }
        public ulong PhoneDirectoryGroupId { get; set; }
        public ulong CreatedAt { get; set; }
        public ulong? CompletedAt { get; set; }
        public string Request { get; set; } = null!;
        public string? Response { get; set; }
        public string Status { get; set; } = null!;
        public uint? RowsCount { get; set; }
        public uint? PercentageOfComplete { get; set; }
    }
}
