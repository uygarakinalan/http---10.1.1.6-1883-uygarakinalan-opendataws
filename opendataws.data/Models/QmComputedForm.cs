using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class QmComputedForm
    {
        public uint Id { get; set; }
        public string Uid { get; set; } = null!;
        public ulong UserId { get; set; }
        public ulong FormId { get; set; }
        public string Answers { get; set; } = null!;
        public int TotalScore { get; set; }
        public ulong CreatedAt { get; set; }
        public ulong? UpdatedAt { get; set; }
        public ulong? DeletedAt { get; set; }
        public string? DetailText { get; set; }
        public string Extension { get; set; } = null!;
        public string CallType { get; set; } = null!;
        public int? AutoCallPlan { get; set; }
        public string? Caller { get; set; }
        public string? Name { get; set; }
        public string? DepartmentTitle { get; set; }
        public string? CallTime { get; set; }
        public long? JoinTime { get; set; }
        public int? TelewebQueue { get; set; }
        public string? WhoClosed { get; set; }
        public uint? CallTimeRaw { get; set; }
        public string? Target { get; set; }
        public bool? IsExcludedFromEvaluation { get; set; }
        public int ComputingSeconds { get; set; }
        public string? ObjectionStatus { get; set; }
        public ulong? ObjectionDate { get; set; }
        public ulong? ObjectionReviewDate { get; set; }
    }
}
