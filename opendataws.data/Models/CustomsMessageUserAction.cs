using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class CustomsMessageUserAction
    {
        public uint Id { get; set; }
        public uint CustomsMessageId { get; set; }
        public uint UserId { get; set; }
        public ulong? IncidentNumber { get; set; }
        public ulong CreatedAt { get; set; }
        public string Action { get; set; } = null!;
        public bool Visible { get; set; }
        public string UserIp { get; set; } = null!;
        public string? UserAgent { get; set; }
    }
}
