using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class PhoneDirectoryUser
    {
        public uint Id { get; set; }
        public string? Name { get; set; }
        public ulong? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public ulong? FaxNumber { get; set; }
        public bool IncludeSmsList { get; set; }
        public bool IncludeFaxList { get; set; }
        public bool IncludeEmailList { get; set; }
        public bool Active { get; set; }
        public int GroupId { get; set; }
        public ulong? DeletedAt { get; set; }
        public uint CreatorUserId { get; set; }
        public uint CreatorDepartmentId { get; set; }
        public bool? IncludeCallList { get; set; }
        public ulong? InternalNumber { get; set; }
        public string? Description { get; set; }
        public uint DepartmentId { get; set; }
    }
}
