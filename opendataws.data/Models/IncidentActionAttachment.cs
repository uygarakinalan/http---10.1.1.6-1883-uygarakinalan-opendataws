using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class IncidentActionAttachment
    {
        public uint Id { get; set; }
        public uint IncidentActionId { get; set; }
        public string? RealName { get; set; }
        public string? LocalName { get; set; }
        public string? GeogrophicCoordinate { get; set; }
    }
}
