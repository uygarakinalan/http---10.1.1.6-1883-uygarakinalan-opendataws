using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class UserImportLog
    {
        public uint Id { get; set; }
        public ulong UserId { get; set; }
        public ulong CreatedAt { get; set; }
        public ulong? CompletedAt { get; set; }
        public string Request { get; set; } = null!;
        public string? Response { get; set; }
        public string? Status { get; set; }
    }
}
