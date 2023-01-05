using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class UserTitle
    {
        public uint Id { get; set; }
        public string Title { get; set; } = null!;
        public uint? DeletedAt { get; set; }
    }
}
