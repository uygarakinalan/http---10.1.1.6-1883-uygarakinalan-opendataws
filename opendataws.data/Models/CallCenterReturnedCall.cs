using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class CallCenterReturnedCall
    {
        public uint Id { get; set; }
        public ulong PhoneNumber { get; set; }
        public ulong? CallDate { get; set; }
        public bool IsReturned { get; set; }
        public ushort? CallCount { get; set; }
        public uint? Queue { get; set; }
        public string? Uid { get; set; }
    }
}
