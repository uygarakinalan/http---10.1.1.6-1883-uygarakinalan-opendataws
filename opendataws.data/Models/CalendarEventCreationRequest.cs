using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class CalendarEventCreationRequest
    {
        public uint Id { get; set; }
        public uint CreatorUserId { get; set; }
        public uint CalendarUserId { get; set; }
        public string RequestModel { get; set; } = null!;
        public string Status { get; set; } = null!;
        public ulong CreatedAt { get; set; }
        public ulong? UpdatedAt { get; set; }
    }
}
