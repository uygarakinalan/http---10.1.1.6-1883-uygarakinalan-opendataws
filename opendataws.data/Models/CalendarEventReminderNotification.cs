using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class CalendarEventReminderNotification
    {
        public uint Id { get; set; }
        public uint CalendarEventId { get; set; }
        public uint UserId { get; set; }
        public uint TimeValue { get; set; }
        public string TimeType { get; set; } = null!;
        public ulong NotificationTime { get; set; }
        public string NotificationMethods { get; set; } = null!;
        public ulong CreatedAt { get; set; }
    }
}
