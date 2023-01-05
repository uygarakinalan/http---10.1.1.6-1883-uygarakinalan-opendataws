using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class IncidentWorkTime
    {
        public uint Id { get; set; }
        public uint IncidentId { get; set; }
        public uint UserId { get; set; }
        public uint StartTime { get; set; }
        public uint? EndTime { get; set; }
    }
}
