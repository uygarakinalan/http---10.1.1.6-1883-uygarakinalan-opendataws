using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class TelewebBreakOption
    {
        public uint Id { get; set; }
        public string Name { get; set; } = null!;
        public string Color { get; set; } = null!;
        public DateTime? DeletedAt { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsWorking { get; set; }
        public bool IsBreakReqeustRequired { get; set; }
    }
}
