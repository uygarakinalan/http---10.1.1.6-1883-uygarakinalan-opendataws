using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class IncidentNotification
    {
        public uint Id { get; set; }
        public ulong IncidentId { get; set; }
        public int? IncidentActionId { get; set; }
        public int UserId { get; set; }
        public string Target { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string Message { get; set; } = null!;
        public ulong CreatedAt { get; set; }
    }
}
