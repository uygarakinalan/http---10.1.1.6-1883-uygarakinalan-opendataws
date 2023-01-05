using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class BirikimAuthToken
    {
        public uint Id { get; set; }
        public string Token { get; set; } = null!;
        public string UserIp { get; set; } = null!;
        public uint UserId { get; set; }
        public string ActiveDirectoryUsername { get; set; } = null!;
        public ulong CreatedAt { get; set; }
        public ulong? DeletedAt { get; set; }
    }
}
