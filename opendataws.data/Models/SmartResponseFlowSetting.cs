using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class SmartResponseFlowSetting
    {
        public uint Id { get; set; }
        public string? Key { get; set; }
        public string? Value { get; set; }
        public uint CreatedAt { get; set; }
        public uint UpdatedAt { get; set; }
    }
}
