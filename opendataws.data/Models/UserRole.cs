using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class UserRole
    {
        public uint Id { get; set; }
        public string Title { get; set; } = null!;
        public uint? DeletedAt { get; set; }
        public string? Icon { get; set; }
        public uint? CreatorUserId { get; set; }
    }
}
