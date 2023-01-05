using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class TarnetLog
    {
        public uint Id { get; set; }
        public uint? TarnetCustomerId { get; set; }
        public string? CallId { get; set; }
        public string Direction { get; set; } = null!;
        public string? Note { get; set; }
        public ulong CreatedAt { get; set; }
        public ulong? UpdatedAt { get; set; }
        public ulong? Extension { get; set; }
        public ulong? Target { get; set; }
        public string? Uid { get; set; }
        public sbyte? Menu { get; set; }
    }
}
