using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class TimeConditionGroup
    {
        public uint Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public ulong CreatedAt { get; set; }
        public ulong? DeletedAt { get; set; }
        public string? MesaiIciAnons { get; set; }
        public string? MesaiDisiAnons { get; set; }
    }
}
