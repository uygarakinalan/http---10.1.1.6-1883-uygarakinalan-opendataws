using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class CustomsIntegration
    {
        public uint Id { get; set; }
        public uint? CustomsAccountId { get; set; }
        public string? IncidentSourceId { get; set; }
        public string IntegrationTitle { get; set; } = null!;
        public string IntegrationSource { get; set; } = null!;
        public string? Token { get; set; }
        public string? Link { get; set; }
        public uint CreatorUserId { get; set; }
        public ulong? DeletedAt { get; set; }
        public ulong CreatedAt { get; set; }
        public bool IsReadonly { get; set; }
    }
}
