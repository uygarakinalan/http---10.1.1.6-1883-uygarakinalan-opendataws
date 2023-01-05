using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class HesCodeLog
    {
        public uint Id { get; set; }
        public uint? IncidentId { get; set; }
        public string Status { get; set; } = null!;
        public ulong? ExpirationDate { get; set; }
        public string? MaskedIdentityNumber { get; set; }
        public string? MaskedFirstname { get; set; }
        public string? MaskedLastname { get; set; }
        public string? Response { get; set; }
        public ulong CreatedAt { get; set; }
        public string? HesCode { get; set; }
    }
}
