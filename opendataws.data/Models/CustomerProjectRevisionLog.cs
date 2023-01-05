using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class CustomerProjectRevisionLog
    {
        public uint Id { get; set; }
        public ulong? EarlyDeliveryMonth { get; set; }
        public ulong ProjectId { get; set; }
        public string? OldCalculation { get; set; }
        public string? NewCalculation { get; set; }
        public ulong CreatedAt { get; set; }
        public string Request { get; set; } = null!;
        public ulong UserId { get; set; }
        public string UserIp { get; set; } = null!;
    }
}
