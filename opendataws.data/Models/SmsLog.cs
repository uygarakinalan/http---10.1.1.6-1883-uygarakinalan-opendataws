using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class SmsLog
    {
        public uint Id { get; set; }
        public uint IncidentActionId { get; set; }
        public long Recipient { get; set; }
        public string Message { get; set; } = null!;
        public string Response { get; set; } = null!;
    }
}
