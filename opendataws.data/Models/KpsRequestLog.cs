using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class KpsRequestLog
    {
        public uint Id { get; set; }
        public string IdentificationNumber { get; set; } = null!;
        public ulong CreatedAt { get; set; }
        public uint? UserId { get; set; }
        public string UserIp { get; set; } = null!;
        public string? UserAgent { get; set; }
        public string? RequestUrl { get; set; }
        public string? BirthDate { get; set; }
    }
}
