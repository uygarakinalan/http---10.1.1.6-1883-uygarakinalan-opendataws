using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class WebFormObject
    {
        public uint Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Fields { get; set; }
        public string? TitleField { get; set; }
        public string? ObjectType { get; set; }
        public ulong? CreatedAt { get; set; }
        public ulong? UpdatedAt { get; set; }
        public ulong? DeletedAt { get; set; }
        public string? CompletedStepDepartmentIds { get; set; }
        public string? CompletedStepTopicIds { get; set; }
    }
}
