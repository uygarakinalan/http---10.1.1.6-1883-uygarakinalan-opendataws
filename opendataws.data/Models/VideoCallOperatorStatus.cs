using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class VideoCallOperatorStatus
    {
        public uint Id { get; set; }
        public uint UserId { get; set; }
        public string RegisterName { get; set; } = null!;
        public string Status { get; set; } = null!;
    }
}
