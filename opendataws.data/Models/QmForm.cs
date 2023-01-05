using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class QmForm
    {
        public uint Id { get; set; }
        public string Title { get; set; } = null!;
        public bool IsActive { get; set; }
        public ulong CreatedAt { get; set; }
        public ulong? UpdatedAt { get; set; }
        public ulong? DeletedAt { get; set; }
    }
}
