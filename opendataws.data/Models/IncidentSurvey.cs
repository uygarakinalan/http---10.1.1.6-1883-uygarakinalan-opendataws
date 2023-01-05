using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class IncidentSurvey
    {
        public uint Id { get; set; }
        public uint IncidentId { get; set; }
        public uint WebformId { get; set; }
        public ulong CreatedAt { get; set; }
        public ulong? UpdatedAt { get; set; }
    }
}
