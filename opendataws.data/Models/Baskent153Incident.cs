using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class Baskent153Incident
    {
        public uint Id { get; set; }
        public string IncidentPublicToken { get; set; } = null!;
        public string OriginalId { get; set; } = null!;
        public ulong CreatedAt { get; set; }
    }
}
