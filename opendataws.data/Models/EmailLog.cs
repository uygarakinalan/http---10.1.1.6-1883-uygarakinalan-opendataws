using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class EmailLog
    {
        public uint Id { get; set; }
        public uint IncidentActionId { get; set; }
        public string Recipient { get; set; } = null!;
        public string Subject { get; set; } = null!;
        public string View { get; set; } = null!;
        public string Data { get; set; } = null!;
        public string? Response { get; set; }
    }
}
