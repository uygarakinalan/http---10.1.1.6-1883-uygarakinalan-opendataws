using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class ScheduledIncident
    {
        public uint Id { get; set; }
        public string? RepetitionFrequencyType { get; set; }
        public string? RepetitionDays { get; set; }
        public string EndTimeType { get; set; } = null!;
        public ulong? EndTime { get; set; }
        public sbyte? NumberOfRepetitions { get; set; }
        public string IncidentRequest { get; set; } = null!;
        public int NumberOfWork { get; set; }
        public ulong CreatedAt { get; set; }
        public ulong? DeletedAt { get; set; }
        public uint? CreatorUserId { get; set; }
        public ulong? OneTime { get; set; }
        public uint IncidentCreateTime { get; set; }
        public string? Title { get; set; }
        public ulong? StartTime { get; set; }
    }
}
