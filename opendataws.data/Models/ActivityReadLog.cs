using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class ActivityReadLog
    {
        public uint Id { get; set; }
        public ulong UserId { get; set; }
        public ulong ActivityId { get; set; }
    }
}
