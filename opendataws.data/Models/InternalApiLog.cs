using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class InternalApiLog
    {
        public uint Id { get; set; }
        public string UserIp { get; set; } = null!;
        public string? UserAgent { get; set; }
        public string? Request { get; set; }
        public ulong PerformadAt { get; set; }
    }
}
