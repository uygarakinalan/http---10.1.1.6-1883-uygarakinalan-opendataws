using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class IncidentNotificationSetting
    {
        public uint Id { get; set; }
        public string IncidentAction { get; set; } = null!;
        public int IncidentSourceId { get; set; }
        public string Target { get; set; } = null!;
        public bool? Active { get; set; }
        public string Text { get; set; } = null!;
        public uint? DeletedAt { get; set; }
        public string Options { get; set; } = null!;
        public string Conditions { get; set; } = null!;
    }
}
