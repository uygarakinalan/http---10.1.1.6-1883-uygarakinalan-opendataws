using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class ArkSignerAuthLog
    {
        public uint Id { get; set; }
        public string State { get; set; } = null!;
        public string UserIp { get; set; } = null!;
        public string UserAgent { get; set; } = null!;
        public ulong? UserId { get; set; }
        public string? AccessToken { get; set; }
        public ulong CreatedAt { get; set; }
        public ulong? UpdatedAt { get; set; }
        public string? UserReference { get; set; }
        public string? Stage { get; set; }
        public string? Error { get; set; }
    }
}
