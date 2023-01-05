using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class UserRRMemory
    {
        public uint Id { get; set; }
        public ulong LastUserId { get; set; }
        public string Process { get; set; } = null!;
        public ulong UpdatedAt { get; set; }
    }
}
