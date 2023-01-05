using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class ServerRecord
    {
        public uint Id { get; set; }
        public uint? UserId { get; set; }
        public string Text { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string? ReferenceModel { get; set; }
        public ulong? CreatedAt { get; set; }
        public int? ReferenceId { get; set; }
    }
}
