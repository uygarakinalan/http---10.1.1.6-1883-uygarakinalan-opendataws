using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class ContactInfo
    {
        public uint Id { get; set; }
        public uint ContactId { get; set; }
        public string? Key { get; set; }
        public string? Value { get; set; }
        public uint? DeletedAt { get; set; }
        public ulong? IntValue { get; set; }
    }
}
