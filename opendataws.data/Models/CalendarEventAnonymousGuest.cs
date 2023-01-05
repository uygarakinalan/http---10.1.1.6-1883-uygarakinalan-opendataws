using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class CalendarEventAnonymousGuest
    {
        public uint Id { get; set; }
        public string Name { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public ulong? MobilePhone { get; set; }
        public string? Email { get; set; }
        public ulong CreatedAt { get; set; }
    }
}
