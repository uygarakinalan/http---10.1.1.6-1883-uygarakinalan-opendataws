using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class LoginLog
    {
        public uint Id { get; set; }
        public ulong? UserId { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? UserAgent { get; set; }
        public string? UserIp { get; set; }
        public uint PerformedAt { get; set; }
        public bool IsLoggedIn { get; set; }
    }
}
