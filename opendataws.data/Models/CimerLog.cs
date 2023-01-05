using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class CimerLog
    {
        public uint Id { get; set; }
        public uint IncidentActionId { get; set; }
        public uint CimerIncidentId { get; set; }
        public string Text { get; set; } = null!;
        public string Response { get; set; } = null!;
        public bool IsCompleted { get; set; }
        public bool IsAnswered { get; set; }
        public bool IsApproved { get; set; }
        public bool IsReturned { get; set; }
        public string Action { get; set; } = null!;
        public string? CompletionType { get; set; }
        public string? IsHeld { get; set; }
        public string? Options { get; set; }
    }
}
