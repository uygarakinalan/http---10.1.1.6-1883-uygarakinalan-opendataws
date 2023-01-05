using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class HospitalSetting
    {
        public uint Id { get; set; }
        public string Setting { get; set; } = null!;
        public string? Value { get; set; }
    }
}
