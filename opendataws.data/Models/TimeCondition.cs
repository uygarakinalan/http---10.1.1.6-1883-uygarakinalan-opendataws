using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class TimeCondition
    {
        public uint Id { get; set; }
        public int TimeConditionGroupId { get; set; }
        public string Type { get; set; } = null!;
        public string Data { get; set; } = null!;
        public ulong CreatedAt { get; set; }
    }
}
