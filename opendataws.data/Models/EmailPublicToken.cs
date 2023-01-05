using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class EmailPublicToken
    {
        public uint Id { get; set; }
        public string Token { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string TypeId { get; set; } = null!;
        public ulong CreatedAt { get; set; }
    }
}
