using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class CustomerIsActiveLog
    {
        public uint Id { get; set; }
        public string? Note { get; set; }
        public bool IsActive { get; set; }
        public uint? CustomerProjectRevisionId { get; set; }
        public ulong CreatedAt { get; set; }
        public uint UserId { get; set; }
        public string UserIp { get; set; } = null!;
    }
}
