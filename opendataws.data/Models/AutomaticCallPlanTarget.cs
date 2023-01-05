using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class AutomaticCallPlanTarget
    {
        public uint Id { get; set; }
        public uint AutomaticCallPlanId { get; set; }
        public uint PhoneDirectoryUserId { get; set; }
        public string Status { get; set; } = null!;
        public byte? CallCount { get; set; }
        public ulong CreatedAt { get; set; }
        public ulong? UpdatedAt { get; set; }
        public uint? AutomaticCallLogId { get; set; }
        public string? SurveyScore { get; set; }
        public string? Extra { get; set; }
    }
}
