using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class QmComputedFormObjection
    {
        public uint Id { get; set; }
        public int QmComputedFormId { get; set; }
        public string ReasonForObjection { get; set; } = null!;
        public string Status { get; set; } = null!;
        public string? OldAnswers { get; set; }
        public string? NewAnswers { get; set; }
        public short? OldTotalScore { get; set; }
        public short? NewTotalScore { get; set; }
        public ulong CreatedAt { get; set; }
        public ulong? ObjectionReviewDate { get; set; }
        public string? ObjectionDeniedText { get; set; }
        public string? OldDetailText { get; set; }
        public string? NewDetailText { get; set; }
        public uint? ObjectionReviewerUserId { get; set; }
    }
}
