using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class CallDispositionCode
    {
        public uint Id { get; set; }
        public string Name { get; set; } = null!;
        public bool? Active { get; set; }
        public ulong CreatedAt { get; set; }
        public ulong UpdatedAt { get; set; }
        public ulong? DeletedAt { get; set; }
        public int ParentCodeId { get; set; }
        public int ParentPriority { get; set; }
    }
}
