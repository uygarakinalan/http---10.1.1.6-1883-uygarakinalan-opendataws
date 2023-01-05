using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class UserApiToken
    {
        public uint Id { get; set; }
        public uint UserId { get; set; }
        public string ApiToken { get; set; } = null!;
        public string RegisteredIp { get; set; } = null!;
        public string RegisteredUserAgent { get; set; } = null!;
        public uint? ExpiresAt { get; set; }
        public uint? CreatedAt { get; set; }
        public uint? UpdatedAt { get; set; }
        public uint? DeletedAt { get; set; }
    }
}
