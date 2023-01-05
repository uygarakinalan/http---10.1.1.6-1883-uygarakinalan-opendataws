using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class FrequentlyAskedQuestion
    {
        public uint Id { get; set; }
        public string Question { get; set; } = null!;
        public string Answer { get; set; } = null!;
        public bool IsPublic { get; set; }
        public uint? DepartmentId { get; set; }
        public uint UserId { get; set; }
        public ulong CreatedAt { get; set; }
        public ulong? UpdatedAt { get; set; }
        public ulong? DeletedAt { get; set; }
        public string? File { get; set; }
    }
}
