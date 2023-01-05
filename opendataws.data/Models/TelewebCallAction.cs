using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class TelewebCallAction
    {
        public uint Id { get; set; }
        public uint UserId { get; set; }
        public ulong CreatedAt { get; set; }
        public string Action { get; set; } = null!;
        public string Uid { get; set; } = null!;
        public decimal? Start { get; set; }
        public decimal? End { get; set; }
    }
}
