using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class WorkFlow
    {
        public uint Id { get; set; }
        public string? IncidentSourceIds { get; set; }
        public string? Departments { get; set; }
        public string? Sender { get; set; }
        public string? Receiver { get; set; }
        public string? Text { get; set; }
        public string? IncidentAction { get; set; }
        public string WhatToDo { get; set; } = null!;
        public int Target { get; set; }
        public bool? Active { get; set; }
        public byte Priority { get; set; }
        public uint? DeletedAt { get; set; }
        public string? ApprovalPriority { get; set; }
        public string? MultipleApproveTargets { get; set; }
        public string Options { get; set; } = null!;
    }
}
