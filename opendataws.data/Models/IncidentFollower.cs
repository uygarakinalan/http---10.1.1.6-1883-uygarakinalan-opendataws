using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class IncidentFollower
    {
        public uint Id { get; set; }
        public uint UserId { get; set; }
        public uint IncidentId { get; set; }
        public int FollowedAt { get; set; }
        public uint? UnfollowedAt { get; set; }
        public uint? AddingUserId { get; set; }
    }
}
