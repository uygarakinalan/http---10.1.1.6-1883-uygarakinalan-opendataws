using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class PhoneDirectoryGroup
    {
        public uint Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }
        public ulong? DeletedAt { get; set; }
        public uint CreatorUserId { get; set; }
        public uint DepartmentId { get; set; }
        public bool IsOpenToEveryone { get; set; }
        public bool SendToCcenter { get; set; }
    }
}
