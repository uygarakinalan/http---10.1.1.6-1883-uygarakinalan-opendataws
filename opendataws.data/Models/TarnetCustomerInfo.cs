using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class TarnetCustomerInfo
    {
        public uint Id { get; set; }
        public uint? TarnetCustomerId { get; set; }
        public string Key { get; set; } = null!;
        public string? Value { get; set; }
        public ulong? IntValue { get; set; }
        public ulong CreatedAt { get; set; }
        public ulong? UpdatedAt { get; set; }
        public ulong? DeletedAt { get; set; }
    }
}
