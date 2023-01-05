using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class IncidentInternalReturn
    {
        public uint Id { get; set; }
        public uint IncidentId { get; set; }
        public uint IncidentActionId { get; set; }
        public uint? DepartmentId { get; set; }
        public uint? UserId { get; set; }
        public ulong CreatedAt { get; set; }
        public ulong? DeletedAt { get; set; }
    }
}
