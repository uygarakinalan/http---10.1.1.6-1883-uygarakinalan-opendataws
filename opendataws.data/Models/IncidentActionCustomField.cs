using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class IncidentActionCustomField
    {
        public uint Id { get; set; }
        public uint IncidentId { get; set; }
        public uint IncidentActionId { get; set; }
        public string CustomFieldId { get; set; } = null!;
        public string Value { get; set; } = null!;
        public bool? ReportsNotInclude { get; set; }
        public string? Reference { get; set; }
        public int? ReferenceId { get; set; }
    }
}
