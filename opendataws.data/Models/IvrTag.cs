using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class IvrTag
    {
        public uint Id { get; set; }
        public ulong? IvrId { get; set; }
        public ulong? Key { get; set; }
        public string? Value { get; set; }
    }
}
