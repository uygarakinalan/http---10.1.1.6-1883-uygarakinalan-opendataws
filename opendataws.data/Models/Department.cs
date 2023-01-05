using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class Department
    {
        public uint Id { get; set; }
        public string Title { get; set; } = null!;
        public uint ParentDepartmentId { get; set; }
        public uint ParentPriority { get; set; }
        public bool Private { get; set; }
        public uint? DeletedAt { get; set; }
        public uint? TelewebQueue { get; set; }
        public string? PublicToken { get; set; }
        public uint? TelewebIncidentSourceId { get; set; }
        public bool? AllowTransferIfEmpty { get; set; }
        public string? TransferAllowedIncidentSourceIds { get; set; }
        public bool? AllowTransfer { get; set; }
        public string? InternalReturnTarget { get; set; }
        public sbyte? IlId { get; set; }
        public string? Address { get; set; }
        public byte WorkingTimeoutSeconds { get; set; }
        public ushort BreakTime { get; set; }
        public ushort? ServiceLevelSeconds { get; set; }
        public short? LogoIsyeriKodu { get; set; }
        public string? TelewebIncomingCallAction { get; set; }
        public string? NewTabUrl { get; set; }
        public string? TelewebShortcuts { get; set; }
        public string? PhoneDirectoryGroupIds { get; set; }
        public bool TelewebIncomingTone { get; set; }
        public bool ReturnEscapeCall { get; set; }
        public ulong? ReturnEscapeCallAnonsId { get; set; }
        public string? OutboundCid { get; set; }
        public string? CallWelcomeScreenFields { get; set; }
        public bool OpenDifferentWebforms { get; set; }
        public string? DifferentWebforms { get; set; }
        public bool ReturnOffTimeCall { get; set; }
        public uint? ReturnOffTimeAnonsId { get; set; }
        public string? BreakOptions { get; set; }
        public byte LastWasInWrapUpSecond { get; set; }
        public bool? MolayiSinirla { get; set; }
        public sbyte? KuyruktaBekleyenKisiSayisiMolaSiniri { get; set; }
        public bool? TakeBreakIfDispositionCodeIsNotSelected { get; set; }
        public short? DispositionCodeTimeoutSeconds { get; set; }
        public short? DispositionCodeTimeout { get; set; }
        public bool? AllowPostponed { get; set; }
        public sbyte? MoladakiKisiSayisiMolaSiniri { get; set; }
        public string? Mudurluk { get; set; }
        public string? BaskanYardimciligi { get; set; }
        public string? TelewebDashboardIncidentSourceId { get; set; }
        public bool? ShowDashboardConvertToPercent { get; set; }
        public string? DaireBaskanligi { get; set; }
    }
}
