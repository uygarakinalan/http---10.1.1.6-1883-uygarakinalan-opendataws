using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class IncidentTimeoutFlow
    {
        public uint Id { get; set; }
        public string Targets { get; set; } = null!;
        public uint CreatedAt { get; set; }
        public uint UpdatedAt { get; set; }
        public uint? DeletedAt { get; set; }
        public string TopicIds { get; set; } = null!;
    }
}
