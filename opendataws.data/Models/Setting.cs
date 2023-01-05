using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class Setting
    {
        public uint Id { get; set; }
        public string Setting1 { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string? Value { get; set; }
        public string? Group { get; set; }
        public int Priority { get; set; }
    }
}
