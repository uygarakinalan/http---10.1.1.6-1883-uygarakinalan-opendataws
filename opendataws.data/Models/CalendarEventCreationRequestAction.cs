using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class CalendarEventCreationRequestAction
    {
        public uint Id { get; set; }
        public uint CalendarEventCreationRequestId { get; set; }
        public uint UserId { get; set; }
        public string Action { get; set; } = null!;
        public ulong CreatedAt { get; set; }
    }
}
