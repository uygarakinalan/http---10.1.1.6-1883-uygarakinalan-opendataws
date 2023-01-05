using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class WhatsappLog
    {
        public uint Id { get; set; }
        public uint? IncidentActionId { get; set; }
        public uint? CustomsMessageId { get; set; }
        public uint CustomsAccountId { get; set; }
        public string? RemoteUserName { get; set; }
        public string Message { get; set; } = null!;
        public string? Response { get; set; }
        public ulong? CustomsIncidentRelationId { get; set; }
        public sbyte? RetryCount { get; set; }
        public ulong? CreatedAt { get; set; }
        public ulong? LastPerformedAt { get; set; }
        public string? Attachments { get; set; }
    }
}
