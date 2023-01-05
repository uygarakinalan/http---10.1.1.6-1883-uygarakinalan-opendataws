using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class IncidentTopic
    {
        public uint Id { get; set; }
        public uint DepartmentId { get; set; }
        public string Title { get; set; } = null!;
        public uint? DeletedAt { get; set; }
        public uint ResponsibleUserId { get; set; }
        public bool? StaffOnly { get; set; }
        public string? TopicType { get; set; }
        public uint? TopicGroupId { get; set; }
        public uint? CreatorUserId { get; set; }
        public uint? CreatedAt { get; set; }
        public uint? UpdatedAt { get; set; }
        public bool? IsActive { get; set; }
        public string? Description { get; set; }
        public string? DefaultIncidentPriority { get; set; }
        public uint? DefaultIncidentTypeId { get; set; }
        public int? WebFormFlowChartId { get; set; }
    }
}
