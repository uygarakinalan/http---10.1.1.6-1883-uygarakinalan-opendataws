using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class EDevletAuthLog
    {
        public uint Id { get; set; }
        public string State { get; set; } = null!;
        public ulong CreatedAt { get; set; }
        public ulong? UpdatedAt { get; set; }
        public string UserIp { get; set; } = null!;
        public string UserAgent { get; set; } = null!;
        public string? Code { get; set; }
        public string? AccessToken { get; set; }
        public ulong? IdentificationNumber { get; set; }
        public ulong? UserId { get; set; }
        public string? LogType { get; set; }
        public ulong? SourceTableId { get; set; }
        public uint? IncidentActionId { get; set; }
    }
}
