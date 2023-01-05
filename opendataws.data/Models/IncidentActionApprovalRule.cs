using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class IncidentActionApprovalRule
    {
        public uint Id { get; set; }
        public uint IncidentActionId { get; set; }
        public uint WorkFlowId { get; set; }
        public string ApprovalRules { get; set; } = null!;
        public byte CurrentOrder { get; set; }
        public uint? OldResponsibleUserId { get; set; }
        public uint? OldResponsibleDepartmentId { get; set; }
    }
}
