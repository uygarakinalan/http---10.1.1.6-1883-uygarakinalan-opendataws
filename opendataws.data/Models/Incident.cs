using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class Incident
    {
        public uint Id { get; set; }
        public uint Number { get; set; }
        public uint IncidentSourceId { get; set; }
        public ulong? OriginalId { get; set; }
        public uint MasterIncidentId { get; set; }
        public uint DepartmentId { get; set; }
        public uint ResponsibleUserId { get; set; }
        public uint CreationDuration { get; set; }
        public uint CreatedAt { get; set; }
        public byte ReopenCount { get; set; }
        public uint UpdatedAt { get; set; }
        public uint ClosedAt { get; set; }
        public ulong ExceptSeconds { get; set; }
        public string PublicToken { get; set; } = null!;
        public int TopicId { get; set; }
        public bool DidTopicTimeout { get; set; }
        public bool IsAnonymous { get; set; }
        public bool HideContactInfo { get; set; }
        public string? Status { get; set; }
        public string Priority { get; set; } = null!;
        public byte IlId { get; set; }
        public ushort IlceId { get; set; }
        public uint MahalleId { get; set; }
        public ulong SokakId { get; set; }
        public uint CaddeId { get; set; }
        public string DisKapiNo { get; set; } = null!;
        public string IcKapiNo { get; set; } = null!;
        public string GeogrophicCoordinate { get; set; } = null!;
        public ulong MobilePhone { get; set; }
        public ulong WorkPhone { get; set; }
        public ulong HomePhone { get; set; }
        public string Name { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public ulong IdentificationNumber { get; set; }
        public string Email { get; set; } = null!;
        public string Text { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string ContactAddress { get; set; } = null!;
        public string? CompletionType { get; set; }
        public string? IncidentType { get; set; }
        public string? CompletionText { get; set; }
        public ulong? ScheduledAt { get; set; }
        public uint? CreatorDepartmentId { get; set; }
        public uint? CreatorUserId { get; set; }
        public bool IsMessageCombine { get; set; }
        public bool IsDivided { get; set; }
        public bool IsOtherDepartmentShow { get; set; }
        public string? Gender { get; set; }
        public uint? EducationStatusId { get; set; }
        public uint? IncidentTypeId { get; set; }
        public uint? CompletionSurveyIncidentId { get; set; }
        public string? AnswerTypes { get; set; }
        public bool? PendingSequentialApproval { get; set; }
        public bool HasCallRecord { get; set; }
        public uint? WorkTime { get; set; }
        public byte? CompletePercentage { get; set; }
        public uint? BinaNo { get; set; }
        public ulong? AdresNo { get; set; }
        public uint? ApprovalRequiredActionId { get; set; }
        public uint? PostponedTo { get; set; }
        public uint? CompletionReasonId { get; set; }
        public byte? CompletionSurveyStatus { get; set; }
        public bool? IgnoreOwnerNotifications { get; set; }
        public byte? SurveyScore { get; set; }
        public bool? IsAutoClosed { get; set; }
        public DateOnly? BirthDate { get; set; }
        public bool CanProcessWhenTopicTimeout { get; set; }
        public int? CompletionSurveyUserId { get; set; }
        public ulong? CompletedAt { get; set; }
        public uint? CompleteDepartmentId { get; set; }
        public uint? CompleteUserId { get; set; }
        public bool? IsMutedCompletionSurvey { get; set; }
        public bool SaveTransferredAt { get; set; }
        public ulong? TransferredAt { get; set; }
        public uint? CompleterUserId { get; set; }
    }
}
