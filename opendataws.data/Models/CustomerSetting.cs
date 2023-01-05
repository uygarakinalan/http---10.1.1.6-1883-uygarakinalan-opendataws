using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class CustomerSetting
    {
        public uint Id { get; set; }
        public string Setting { get; set; } = null!;
        public string Value { get; set; } = null!;
    }
}
