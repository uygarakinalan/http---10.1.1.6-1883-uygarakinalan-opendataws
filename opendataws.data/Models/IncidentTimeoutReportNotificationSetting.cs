using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class IncidentTimeoutReportNotificationSetting
    {
        public uint Id { get; set; }
        public bool? IsActive { get; set; }
        public string? RepetitionFrequencyType { get; set; }
        public string? RepetitionDays { get; set; }
        public string? IncidentSources { get; set; }
        public ulong? WorkTime { get; set; }
        public ulong? UpdatedAt { get; set; }
    }
}
