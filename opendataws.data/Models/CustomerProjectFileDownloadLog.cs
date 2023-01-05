using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class CustomerProjectFileDownloadLog
    {
        public uint Id { get; set; }
        public uint? UserId { get; set; }
        public uint CustomerProjectFileId { get; set; }
        public ulong CreatedAt { get; set; }
        public bool IsPermitted { get; set; }
        public string UserIp { get; set; } = null!;
        public string? UserAgent { get; set; }
    }
}
