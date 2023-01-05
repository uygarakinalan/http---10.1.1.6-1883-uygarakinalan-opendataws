using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class CustomerActionNote
    {
        public uint Id { get; set; }
        public ulong UserId { get; set; }
        public ulong PerformedAt { get; set; }
        public string Text { get; set; } = null!;
        public uint ActionId { get; set; }
        public ulong? DeletedAt { get; set; }
    }
}
