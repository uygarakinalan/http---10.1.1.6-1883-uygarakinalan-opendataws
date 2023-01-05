using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class TarnetCustomer
    {
        public uint Id { get; set; }
        public string Number { get; set; } = null!;
        public string Name { get; set; } = null!;
        public ulong CreatedAt { get; set; }
        public ulong? UpdatedAt { get; set; }
        public ulong? DeletedAt { get; set; }
        public string? TarnetCustomerType { get; set; }
    }
}
