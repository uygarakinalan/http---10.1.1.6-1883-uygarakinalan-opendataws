using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class IncidentActionTransfer
    {
        public uint Id { get; set; }
        public uint IncidentActionId { get; set; }
        public string Target { get; set; } = null!;
        public uint? DepartmentId { get; set; }
        public uint? UserId { get; set; }
        public uint? GroupId { get; set; }
        public uint? TopicId { get; set; }
        public uint? OldResponsibleUserId { get; set; }
        public uint? OldDepartmentId { get; set; }
        public uint? OldTopicId { get; set; }
        public bool IsInternalReturned { get; set; }
    }
}
