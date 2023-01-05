using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class CustomerProjectAction
    {
        public uint Id { get; set; }
        public uint UserId { get; set; }
        public string? Action { get; set; }
        public ulong PerformedAt { get; set; }
        public uint? ProjectId { get; set; }
        public string? Note { get; set; }
        public string? ActionType { get; set; }
        public string? Extra { get; set; }
    }
}
