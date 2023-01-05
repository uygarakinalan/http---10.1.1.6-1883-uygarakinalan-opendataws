using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class TelewebInternalLog
    {
        public uint Id { get; set; }
        public ulong UserId { get; set; }
        public ulong CreatedAt { get; set; }
        public string Log { get; set; } = null!;
    }
}
