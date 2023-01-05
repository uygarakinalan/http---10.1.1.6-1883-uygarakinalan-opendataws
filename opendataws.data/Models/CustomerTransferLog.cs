using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class CustomerTransferLog
    {
        public uint Id { get; set; }
        public uint UserId { get; set; }
        public ulong CreatedAt { get; set; }
        public string Request { get; set; } = null!;
        public string Response { get; set; } = null!;
        public ulong? FinishTime { get; set; }
    }
}
