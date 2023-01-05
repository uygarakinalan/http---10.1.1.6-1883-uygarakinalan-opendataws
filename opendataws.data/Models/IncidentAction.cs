using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class IncidentAction
    {
        public uint Id { get; set; }
        public uint IncidentId { get; set; }
        public uint UserId { get; set; }
        public uint PerformedAt { get; set; }
        public uint OldResponsibleUserId { get; set; }
        public string? Text { get; set; }
        public bool ApprovalRequired { get; set; }
        public string? Action { get; set; }
        public bool? IsMuted { get; set; }
        public string? Source { get; set; }
        public string? HtmlText { get; set; }
    }
}
