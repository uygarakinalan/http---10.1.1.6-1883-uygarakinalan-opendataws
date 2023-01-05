using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class CustomerProjectInfo
    {
        public uint Id { get; set; }
        public uint ProjectId { get; set; }
        public string Key { get; set; } = null!;
        public string Value { get; set; } = null!;
        public ulong CreatedAt { get; set; }
        public ulong? UpdatedAt { get; set; }
    }
}
