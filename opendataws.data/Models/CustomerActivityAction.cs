using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class CustomerActivityAction
    {
        public uint Id { get; set; }
        public uint UserId { get; set; }
        public string Action { get; set; } = null!;
        public string? Data { get; set; }
        public string? IpAddress { get; set; }
        public uint? CustomerActivityId { get; set; }
        public ulong? PerformedAt { get; set; }
    }
}
