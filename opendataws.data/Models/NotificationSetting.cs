using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class NotificationSetting
    {
        public uint Id { get; set; }
        public string IncidentAction { get; set; } = null!;
        public int IncidentSourceId { get; set; }
        public string? Target { get; set; }
        public bool? Active { get; set; }
        public string Text { get; set; } = null!;
        public uint? DeletedAt { get; set; }
    }
}
