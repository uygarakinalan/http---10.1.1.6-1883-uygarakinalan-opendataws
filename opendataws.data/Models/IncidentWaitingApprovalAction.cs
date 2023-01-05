using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class IncidentWaitingApprovalAction
    {
        public uint Id { get; set; }
        public ulong IncidentId { get; set; }
        public ulong IncidentActionId { get; set; }
        public ulong UserId { get; set; }
        public string Action { get; set; } = null!;
    }
}
