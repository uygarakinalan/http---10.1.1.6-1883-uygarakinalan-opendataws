using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class HospitalDepartment
    {
        public uint Id { get; set; }
        public ulong HbysDepartmentId { get; set; }
        public string Name { get; set; } = null!;
        public ulong? DeletedAt { get; set; }
        public ulong? UpdatedAt { get; set; }
        public ulong CreatedAt { get; set; }
    }
}
