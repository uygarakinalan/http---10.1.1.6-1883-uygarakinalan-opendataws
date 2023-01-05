using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class AutomaticCallPlanExcelLog
    {
        public uint Id { get; set; }
        public ulong UserId { get; set; }
        public uint AutomaticCallPlanId { get; set; }
        public ulong CreatedAt { get; set; }
        public bool? Completed { get; set; }
        public string? LocalName { get; set; }
        public string? UserIp { get; set; }
        public string? UserAgent { get; set; }
    }
}
