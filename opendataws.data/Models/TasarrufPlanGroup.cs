using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class TasarrufPlanGroup
    {
        public uint Id { get; set; }
        public string GroupId { get; set; } = null!;
        public uint PlanId { get; set; }
        public ulong CreatedAt { get; set; }
        public ulong? DeletedAt { get; set; }
    }
}
