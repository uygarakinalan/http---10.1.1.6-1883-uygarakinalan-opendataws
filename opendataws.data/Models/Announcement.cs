using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class Announcement
    {
        public uint Id { get; set; }
        public string DepartmentIds { get; set; } = null!;
        public string UserRoleIds { get; set; } = null!;
        public string? Title { get; set; }
        public string? Text { get; set; }
        public string? Color { get; set; }
        public string Position { get; set; } = null!;
        public ulong StartDateTime { get; set; }
        public ulong? FinishDateTime { get; set; }
        public string Size { get; set; } = null!;
        public string? BackgroundColor { get; set; }
        public string? Files { get; set; }
        public bool? IsShouldBeAnswered { get; set; }
        public ulong? UserId { get; set; }
        public ulong? DepartmentId { get; set; }
        public bool IsShouldBeSendSms { get; set; }
        public string? TargetUsers { get; set; }
        public string? Target { get; set; }
    }
}
