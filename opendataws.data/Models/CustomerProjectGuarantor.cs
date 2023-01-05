using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class CustomerProjectGuarantor
    {
        public uint Id { get; set; }
        public uint ProjectId { get; set; }
        public string? Name { get; set; }
        public ulong? IdentificationNumber { get; set; }
        public ulong? MobilePhone { get; set; }
        public string? Address { get; set; }
        public string? Revenues { get; set; }
    }
}
