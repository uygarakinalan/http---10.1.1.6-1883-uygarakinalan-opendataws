using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class AutomaticCallPlan
    {
        public uint Id { get; set; }
        public string Title { get; set; } = null!;
        public string PhoneDirectoryGroupIds { get; set; } = null!;
        public string Method { get; set; } = null!;
        public ulong CreatedAt { get; set; }
        public uint? TelewebQueue { get; set; }
        public ulong? StartAt { get; set; }
        public string? Settings { get; set; }
        public ulong? FinishedAt { get; set; }
        public ulong? PausedAt { get; set; }
        public string? Status { get; set; }
        public bool? IsJobPlanned { get; set; }
        public bool IsConstant { get; set; }
        public string? ApiSecret { get; set; }
        public uint? DeletedAt { get; set; }
        public bool? JobRunRequired { get; set; }
        public string? OutboundCid { get; set; }
        public string? Action { get; set; }
    }
}
