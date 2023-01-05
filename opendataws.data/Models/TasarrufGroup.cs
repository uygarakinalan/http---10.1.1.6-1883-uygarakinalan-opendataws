using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class TasarrufGroup
    {
        public uint Id { get; set; }
        public string Title { get; set; } = null!;
        public uint GroupSize { get; set; }
        public uint HowManyUsed { get; set; }
        public ulong ValidUntil { get; set; }
        public ulong CreatedAt { get; set; }
        public ulong? DeletedAt { get; set; }
        public byte? MaxServiceCostInstallment { get; set; }
    }
}
