using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class DirectSmsLog
    {
        public uint Id { get; set; }
        public ulong UserId { get; set; }
        public ulong CreatedAt { get; set; }
        public ulong PhoneNumber { get; set; }
        public string Message { get; set; } = null!;
        public string Source { get; set; } = null!;
        public string Response { get; set; } = null!;
    }
}
