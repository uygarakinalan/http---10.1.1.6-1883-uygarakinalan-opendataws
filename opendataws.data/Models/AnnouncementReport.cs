using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class AnnouncementReport
    {
        public uint Id { get; set; }
        public uint UserId { get; set; }
        public uint AnnouncementId { get; set; }
        public ulong? AppearedAt { get; set; }
        public ulong? ReadAt { get; set; }
        public string? Response { get; set; }
    }
}
