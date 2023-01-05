using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class ArkSignerLog
    {
        public uint Id { get; set; }
        public ulong UserId { get; set; }
        public ulong? IdentificationNumber { get; set; }
        public ulong AttachmentId { get; set; }
        public string LocalName { get; set; } = null!;
        public string? DocumentUuid { get; set; }
        public bool IsSigned { get; set; }
        public ulong CreatedAt { get; set; }
        public ulong? UpdatedAt { get; set; }
    }
}
