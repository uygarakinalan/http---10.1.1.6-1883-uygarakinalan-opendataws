using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class CustomsAccount
    {
        public uint Id { get; set; }
        public string? Source { get; set; }
        public string Title { get; set; } = null!;
        public string ConnectionInfo { get; set; } = null!;
        public bool? IsActive { get; set; }
        public ulong LastImportedAt { get; set; }
        public uint? IncidentSourceId { get; set; }
        public ulong? DeletedAt { get; set; }
        public string? Options { get; set; }
    }
}
