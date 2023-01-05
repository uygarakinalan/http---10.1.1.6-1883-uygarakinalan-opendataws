using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class IncidentApprovalTime
    {
        public uint Id { get; set; }
        public uint IncidentId { get; set; }
        public uint ActionId { get; set; }
        public ulong PassedTime { get; set; }
        public uint UserId { get; set; }
        public ulong CreatedAt { get; set; }
    }
}
