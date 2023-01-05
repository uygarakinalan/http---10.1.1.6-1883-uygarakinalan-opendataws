using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class IncidentCallRecord
    {
        public uint Id { get; set; }
        public ulong IncidentId { get; set; }
        public string? CallId { get; set; }
        public string? Uid { get; set; }
    }
}
