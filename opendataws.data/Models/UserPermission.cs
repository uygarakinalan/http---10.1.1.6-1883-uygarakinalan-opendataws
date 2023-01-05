using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class UserPermission
    {
        public uint Id { get; set; }
        public uint UserId { get; set; }
        public uint UserRoleId { get; set; }
        public string Action { get; set; } = null!;
        public bool? Permission { get; set; }
        public string? Data { get; set; }
        public uint? DeletedAt { get; set; }
    }
}
