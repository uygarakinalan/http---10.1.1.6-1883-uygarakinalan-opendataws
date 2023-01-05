using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class IncidentShowLog
    {
        public uint Id { get; set; }
        public ulong IncidentId { get; set; }
        public ulong UserId { get; set; }
        public ulong ShowAt { get; set; }
    }
}
