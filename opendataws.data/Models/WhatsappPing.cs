using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class WhatsappPing
    {
        public uint Id { get; set; }
        public ulong PingTarget { get; set; }
        public uint PingId { get; set; }
        public ulong PingSendAt { get; set; }
        public ulong PingReceivedAt { get; set; }
        public ulong PongSendAt { get; set; }
        public ulong PongReceivedAt { get; set; }
        public bool FeedbackSent { get; set; }
    }
}
