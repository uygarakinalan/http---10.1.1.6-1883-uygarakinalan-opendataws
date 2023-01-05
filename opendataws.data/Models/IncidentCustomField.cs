using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class IncidentCustomField
    {
        public uint Id { get; set; }
        public uint IncidentId { get; set; }
        public string CustomFieldId { get; set; } = null!;
        public string Value { get; set; } = null!;
    }
}
