using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class TelewebChannelJoinLog
    {
        public uint Id { get; set; }
        public ulong UserId { get; set; }
        public ulong CreatedAt { get; set; }
        public uint Extension { get; set; }
        public ulong PhoneNumber { get; set; }
        public string Uid { get; set; } = null!;
        public string Type { get; set; } = null!;
    }
}
