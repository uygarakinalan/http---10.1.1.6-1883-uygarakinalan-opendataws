using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class FcmLog
    {
        public uint Id { get; set; }
        public uint? IncidentActionId { get; set; }
        public string? UserFcmTokenIds { get; set; }
        public string Payload { get; set; } = null!;
        public string? Response { get; set; }
    }
}
