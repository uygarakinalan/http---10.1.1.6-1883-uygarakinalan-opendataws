using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class WebForm
    {
        public uint Id { get; set; }
        public string Title { get; set; } = null!;
        public int IncidentSourceId { get; set; }
        public string? PublicUrl { get; set; }
        public string DefaultFields { get; set; } = null!;
        public string CustomFields { get; set; } = null!;
        public bool AllowAnonymous { get; set; }
        public bool VerifyNames { get; set; }
        public bool? Active { get; set; }
        public uint? DeletedAt { get; set; }
        public string? Options { get; set; }
        public bool SendNotificationToIncidentUser { get; set; }
        public int? FloodProtectMinutes { get; set; }
        public bool? CaptchaRequired { get; set; }
        public string? Fields { get; set; }
        public string? IncidentActionInfo { get; set; }
        public bool? SmsVerification { get; set; }
        public uint? CreatorUserId { get; set; }
        public bool IsIncludedInReports { get; set; }
    }
}
