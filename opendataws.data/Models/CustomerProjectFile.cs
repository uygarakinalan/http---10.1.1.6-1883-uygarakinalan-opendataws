using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class CustomerProjectFile
    {
        public uint Id { get; set; }
        public ulong? CustomerProjectId { get; set; }
        public uint? CreatorUserId { get; set; }
        public string LocalName { get; set; } = null!;
        public string RealName { get; set; } = null!;
        public string Type { get; set; } = null!;
        public ulong CreatedAt { get; set; }
        public ulong? DeletedAt { get; set; }
        public uint? CustomerTasarrufProjectCalculationId { get; set; }
    }
}
