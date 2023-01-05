using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class UniversalIncidentLog
    {
        public uint Id { get; set; }
        public uint IncidentId { get; set; }
        public string Request { get; set; } = null!;
        public string? Result { get; set; }
        public sbyte IsCompleted { get; set; }
        public ulong CreatedAt { get; set; }
    }
}
