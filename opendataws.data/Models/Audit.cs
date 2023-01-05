using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class Audit
    {
        public uint Id { get; set; }
        public uint? UserId { get; set; }
        public string Event { get; set; } = null!;
        public uint AuditableId { get; set; }
        public string AuditableType { get; set; } = null!;
        public string? OldValues { get; set; }
        public string? NewValues { get; set; }
        public string? Url { get; set; }
        public string? IpAddress { get; set; }
        public string? UserAgent { get; set; }
        public string? Tags { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
