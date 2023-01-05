using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class CustomsIncidentRelation
    {
        public uint Id { get; set; }
        public ulong IncidentId { get; set; }
        public string? CustomsMessageIds { get; set; }
        public ulong? SelectedMessageId { get; set; }
        public ulong? LastCustomsMessageId { get; set; }
    }
}
