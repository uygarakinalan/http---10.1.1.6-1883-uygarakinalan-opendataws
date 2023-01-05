using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class WebFormCustomField
    {
        public uint Id { get; set; }
        public string Key { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Type { get; set; } = null!;
        public ulong CreatedAt { get; set; }
    }
}
