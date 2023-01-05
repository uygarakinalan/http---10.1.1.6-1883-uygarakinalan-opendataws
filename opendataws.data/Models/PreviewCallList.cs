using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class PreviewCallList
    {
        public uint Id { get; set; }
        public uint AutomaticCallPlanTargetId { get; set; }
        public uint? AutomaticCallLogId { get; set; }
        public string? Action { get; set; }
        public string? Description { get; set; }
        public ulong CreatedAt { get; set; }
        public ulong? ProcessingAt { get; set; }
    }
}
