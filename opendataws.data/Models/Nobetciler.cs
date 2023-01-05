using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class Nobetciler
    {
        public uint Id { get; set; }
        public string? Region { get; set; }
        public string Name { get; set; } = null!;
        public ulong MobilePhone { get; set; }
        public uint? DepartmentId { get; set; }
        public ulong? StartDate { get; set; }
        public ulong? EndDate { get; set; }
        public ulong? CreatedAt { get; set; }
        public ulong? UpdatedAt { get; set; }
        public ulong? DeletedAt { get; set; }
    }
}
