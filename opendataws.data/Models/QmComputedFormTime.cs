using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class QmComputedFormTime
    {
        public uint Id { get; set; }
        public int? QmComputedFormId { get; set; }
        public int UserId { get; set; }
        public uint StartedAt { get; set; }
        public uint? FinishedAt { get; set; }
        public uint? Seconds { get; set; }
        public string? Action { get; set; }
    }
}
