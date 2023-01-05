using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class CalendarEventGuestNotification
    {
        public uint Id { get; set; }
        public uint CalendarEventGuestId { get; set; }
        public uint CalendarEventId { get; set; }
        public string? Action { get; set; }
        public string NotificationMethod { get; set; } = null!;
        public ulong CreatedAt { get; set; }
    }
}
