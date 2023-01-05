using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class UlakfonNotificationLog
    {
        public uint Id { get; set; }
        public int TargetUserId { get; set; }
        public string Target { get; set; } = null!;
        public string Caller { get; set; } = null!;
        public string CreatedAt { get; set; } = null!;
        public string? ReceivedAt { get; set; }
        public string? CallerId { get; set; }
        public string? CallerName { get; set; }
        public string? Status { get; set; }
    }
}
