using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class IncidentActionInfo
    {
        public uint Id { get; set; }
        public uint IncidentActionId { get; set; }
        public bool IsPublic { get; set; }
        public uint? UserApiTokenId { get; set; }
        public string? UserAgent { get; set; }
        public string? UserIp { get; set; }
    }
}
