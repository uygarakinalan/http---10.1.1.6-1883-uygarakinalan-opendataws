using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class InstagramLog
    {
        public uint Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public uint? IncidentActionId { get; set; }
        public uint? CustomsMessageId { get; set; }
        public uint CustomsAccountId { get; set; }
        public string? RemoteUserId { get; set; }
        public string? RemoteUserName { get; set; }
        public string Text { get; set; } = null!;
        public string? Response { get; set; }
        public ulong? CustomsIncidentRelationId { get; set; }
    }
}
