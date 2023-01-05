using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class CallCenterCallDisposition
    {
        public uint Id { get; set; }
        public uint CallDispositionCodeId { get; set; }
        public string Uid { get; set; } = null!;
        public string CallType { get; set; } = null!;
        public uint UserId { get; set; }
        public ulong CreatedAt { get; set; }
    }
}
