using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class AutomatedIncidentAnalysisReport
    {
        public uint Id { get; set; }
        public ulong UserId { get; set; }
        public string ReportName { get; set; } = null!;
        public string Data { get; set; } = null!;
        public string? Period { get; set; }
        public ulong? DeletedAt { get; set; }
        public ulong? CreatedAt { get; set; }
    }
}
