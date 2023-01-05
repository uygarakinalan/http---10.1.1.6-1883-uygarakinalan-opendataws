using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class IncidentSurveyAnswer
    {
        public uint Id { get; set; }
        public uint IncidentSurveyId { get; set; }
        public string WebformFieldKey { get; set; } = null!;
        public string? Value { get; set; }
    }
}
