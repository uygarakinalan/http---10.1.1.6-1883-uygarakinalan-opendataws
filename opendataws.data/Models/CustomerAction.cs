using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class CustomerAction
    {
        public uint Id { get; set; }
        public uint CustomerId { get; set; }
        public uint UserId { get; set; }
        public string? Action { get; set; }
        public ulong PerformedAt { get; set; }
        public string? Text { get; set; }
        public string? Extra { get; set; }
        public string? Status { get; set; }
        public uint? ActivityId { get; set; }
        public uint? DeletedAt { get; set; }
        public ulong? UpdatedAt { get; set; }
    }
}
