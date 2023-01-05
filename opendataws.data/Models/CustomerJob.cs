using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class CustomerJob
    {
        public uint Id { get; set; }
        public string JobName { get; set; } = null!;
        public ulong CreatedAt { get; set; }
        public ulong? DeletedAt { get; set; }
    }
}
