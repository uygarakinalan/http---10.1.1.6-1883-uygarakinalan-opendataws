using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class FaxInbox
    {
        public uint Id { get; set; }
        public string? FaxId { get; set; }
        public uint CustomsAccountId { get; set; }
        public ulong ReceivedAt { get; set; }
        public ulong ImportedAt { get; set; }
        public byte? Page { get; set; }
        public string File { get; set; } = null!;
        public ulong Sender { get; set; }
        public ulong Recipient { get; set; }
        public string? Extra { get; set; }
        public bool IsRead { get; set; }
    }
}
