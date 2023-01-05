using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class User
    {
        public uint Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? RememberToken { get; set; }
        public string? ActiveDirectoryUsername { get; set; }
        public uint DepartmentId { get; set; }
        public long? MobilePhone { get; set; }
        public string? InterPhone { get; set; }
        public string? ProfilePicture { get; set; }
        public bool? Active { get; set; }
        public bool? GetNotificationsViaSms { get; set; }
        public bool? GetNotificationsViaEmail { get; set; }
        public bool? GetNotificationsViaMobileApp { get; set; }
        public uint UserRoleId { get; set; }
        public string ColorBackground { get; set; } = null!;
        public string ColorForeground { get; set; } = null!;
        public byte RowsPerPage { get; set; }
        public byte DefaultIncidentTableId { get; set; }
        public bool ShowSearchBar { get; set; }
        public bool IsSuperAdmin { get; set; }
        public ulong? IdentificationNumber { get; set; }
        public bool IsGroup { get; set; }
        public uint? DeletedAt { get; set; }
        public string? Nickname { get; set; }
        public string? ApiToken { get; set; }
        public uint? TelewebExtension { get; set; }
        public sbyte FontSize { get; set; }
        public uint? UserTitleId { get; set; }
        public bool IncludeInPhoneBook { get; set; }
        public string? CallCenterSynonyms { get; set; }
        public ulong LastLoginTime { get; set; }
        public ulong LastRequestTime { get; set; }
        public bool OnLeave { get; set; }
        public bool LoginFromAllowedIps { get; set; }
        public uint? CreatorUserId { get; set; }
        public string? TotpSecretKey { get; set; }
        public ulong? TotpSecretKeyVerifiedAt { get; set; }
        public bool IsPasswordChangeRequired { get; set; }
        public uint TelewebPenalty { get; set; }
        public ulong? JanusSessionId { get; set; }
        public ulong? JanusHandleId { get; set; }
        public string? IosToken { get; set; }
    }
}
