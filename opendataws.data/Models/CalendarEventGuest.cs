using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class CalendarEventGuest
    {
        public uint Id { get; set; }
        public uint CalendarEventId { get; set; }
        public uint? UserId { get; set; }
        public uint? CalendarEventAnonymousGuestId { get; set; }
        public uint? PhoneDirectoryUserId { get; set; }
        public ulong CreatedAt { get; set; }
        public ulong? DeletedAt { get; set; }
        public string? Status { get; set; }
        public string Token { get; set; } = null!;
        public string? NotificationMethods { get; set; }
    }
}
