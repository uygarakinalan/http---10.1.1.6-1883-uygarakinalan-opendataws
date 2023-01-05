using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class GoogleDriveFile
    {
        public uint Id { get; set; }
        public string? RemoteId { get; set; }
        public string Title { get; set; } = null!;
        public string Type { get; set; } = null!;
        public ulong CreatedAt { get; set; }
        public ulong? UpdatedAt { get; set; }
        public ulong? DeletedAt { get; set; }
        public string? Folder { get; set; }
    }
}
