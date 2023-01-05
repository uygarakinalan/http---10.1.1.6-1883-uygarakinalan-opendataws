using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class PasswordReset1
    {
        public uint Id { get; set; }
        public uint UserId { get; set; }
        public string PublicToken { get; set; } = null!;
        public string Token { get; set; } = null!;
        public string UserIp { get; set; } = null!;
        public bool IsActive { get; set; }
        public bool IsVerified { get; set; }
        public bool IsPasswordChanged { get; set; }
        public string? UserAgent { get; set; }
        public ulong CreatedAt { get; set; }
        public byte ValidationAttemptCount { get; set; }
        public ulong? LastAttemptedAt { get; set; }
    }
}
