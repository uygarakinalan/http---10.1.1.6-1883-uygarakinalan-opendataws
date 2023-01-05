using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class IncidentTimeoutNotification
    {
        public uint Id { get; set; }
        public ulong IncidentNumber { get; set; }
        public string PublicToken { get; set; } = null!;
        public uint UserId { get; set; }
        public ulong TimeoutSecond { get; set; }
        public ulong CreatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
