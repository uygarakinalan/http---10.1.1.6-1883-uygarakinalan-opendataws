using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class SupervisorOperatorStatusChangeLog
    {
        public uint Id { get; set; }
        public ulong UserId { get; set; }
        public uint Extension { get; set; }
        public string OldStatus { get; set; } = null!;
        public string NewStatus { get; set; } = null!;
        public ulong CreatedAt { get; set; }
    }
}
