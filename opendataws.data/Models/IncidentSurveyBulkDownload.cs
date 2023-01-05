using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class IncidentSurveyBulkDownload
    {
        public uint Id { get; set; }
        public string RequestObject { get; set; } = null!;
        public string? IpAddress { get; set; }
        public string? UserAgent { get; set; }
        public string? LocalName { get; set; }
        public uint UserId { get; set; }
        public ulong CreatedAt { get; set; }
        public ulong? DeletedAt { get; set; }
    }
}
