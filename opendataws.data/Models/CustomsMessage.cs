using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class CustomsMessage
    {
        public uint Id { get; set; }
        public string? RemoteId { get; set; }
        public string? RemoteUserId { get; set; }
        public string? RemoteUserName { get; set; }
        public string? RemoteName { get; set; }
        public string? RemoteUserPic { get; set; }
        public string? ParentRemoteId { get; set; }
        public string? Text { get; set; }
        public string? Attachments { get; set; }
        public string? Extra { get; set; }
        public ulong? RealTime { get; set; }
        public ulong? ImportTime { get; set; }
        public string? Source { get; set; }
        public uint CustomsAccountId { get; set; }
        public string? Recipient { get; set; }
        public bool? IsReplyTo { get; set; }
        public bool IsSpam { get; set; }
        public bool Owner { get; set; }
        public bool IsRead { get; set; }
        public bool IsDeleted { get; set; }
        public bool Operation { get; set; }
        public string? IncidentPublicToken { get; set; }
        public uint UpdatedAt { get; set; }
        public bool? IsOrigin { get; set; }
        public uint? UserId { get; set; }
        public bool Favorite { get; set; }
        public string? Link { get; set; }
        public uint? LastMessageId { get; set; }
    }
}
