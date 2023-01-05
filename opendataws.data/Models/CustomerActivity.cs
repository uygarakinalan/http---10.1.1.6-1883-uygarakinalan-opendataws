using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class CustomerActivity
    {
        public uint Id { get; set; }
        public string ActivityType { get; set; } = null!;
        public string? Activity { get; set; }
        public uint CustomerId { get; set; }
        public uint? DepartmentId { get; set; }
        public uint? TopicId { get; set; }
        public uint? ResponsibleUserId { get; set; }
        public ulong? ActivityDate { get; set; }
        public string? Note { get; set; }
        public string? Status { get; set; }
        public string? CompletionType { get; set; }
        public ulong CreatedAt { get; set; }
        public ulong? UpdatedAt { get; set; }
        public ulong? DeletedAt { get; set; }
        public string? CompletionText { get; set; }
        public ulong? CompletionDate { get; set; }
        public bool IsRead { get; set; }
        public ulong? CompleterUser { get; set; }
        public string? ActivityLocation { get; set; }
    }
}
