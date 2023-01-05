using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class UserGroup
    {
        public uint Id { get; set; }
        public string Title { get; set; } = null!;
        public uint UserId { get; set; }
        public uint? DeletedAt { get; set; }
        public uint DepartmentId { get; set; }
    }
}
