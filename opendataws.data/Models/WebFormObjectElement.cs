using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class WebFormObjectElement
    {
        public uint Id { get; set; }
        public uint ObjectId { get; set; }
        public string? Custom { get; set; }
        public bool? Status { get; set; }
        public ulong? CreatedAt { get; set; }
        public ulong? UpdatedAt { get; set; }
        public ulong? DeletedAt { get; set; }
        public string? LastStates { get; set; }
    }
}
