using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class WebFormCustomTable
    {
        public uint Id { get; set; }
        public string Source { get; set; } = null!;
        public ulong Key { get; set; }
        public string Value { get; set; } = null!;
    }
}
