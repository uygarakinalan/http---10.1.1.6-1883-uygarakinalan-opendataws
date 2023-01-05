using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class OutOfWorkCallLog
    {
        public uint Id { get; set; }
        public ulong DialNumber { get; set; }
        public ulong CreatedAt { get; set; }
    }
}
