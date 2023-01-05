using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class IbbIncident
    {
        public uint Id { get; set; }
        public int IncidentNumber { get; set; }
        public string OriginalId { get; set; } = null!;
        public int SecurityNumber { get; set; }
        public ulong CreatedAt { get; set; }
        public string? SrId { get; set; }
        public string? Type { get; set; }
        public bool? IsCompleted { get; set; }
        public bool? IsTransferred { get; set; }
    }
}
