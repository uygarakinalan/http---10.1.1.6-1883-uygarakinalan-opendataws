using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class TelewebDoCallLog
    {
        public uint Id { get; set; }
        public uint Extension { get; set; }
        public long Target { get; set; }
        public string? Uid { get; set; }
        public string? CallId { get; set; }
        public ulong CreatedAt { get; set; }
        public ulong? ReceivedAt { get; set; }
    }
}
