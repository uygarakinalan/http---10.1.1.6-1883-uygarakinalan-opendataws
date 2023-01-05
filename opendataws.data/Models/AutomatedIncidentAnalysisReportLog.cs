using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class AutomatedIncidentAnalysisReportLog
    {
        public uint Id { get; set; }
        public ulong AutomatedIncidentAnalysisReportId { get; set; }
        public bool Status { get; set; }
        public string? FilePath { get; set; }
        public ulong? JobPerformedAt { get; set; }
        public ulong? CreatedAt { get; set; }
    }
}
