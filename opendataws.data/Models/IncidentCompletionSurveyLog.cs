using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class IncidentCompletionSurveyLog
    {
        public uint Id { get; set; }
        public uint IncidentId { get; set; }
        public uint IncidentActionId { get; set; }
        public uint? CompletionSurveyIncidentId { get; set; }
        public ulong CreatedAt { get; set; }
        public uint? IncidentSurveyId { get; set; }
        public uint? WebformId { get; set; }
    }
}
