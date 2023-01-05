using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class CustomerFailedOutboundCall
    {
        public uint Id { get; set; }
        public ulong? CallerId { get; set; }
        public ulong? CallerDepartment { get; set; }
        public ulong? CreatedAt { get; set; }
        public ulong? DeletedAt { get; set; }
        public ulong PhoneNumber { get; set; }
        public string Status { get; set; } = null!;
        public bool? IsRead { get; set; }
    }
}
