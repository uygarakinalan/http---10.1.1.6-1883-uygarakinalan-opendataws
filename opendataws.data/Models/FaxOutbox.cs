using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class FaxOutbox
    {
        public uint Id { get; set; }
        public string? FaxId { get; set; }
        public string? Subject { get; set; }
        public uint UserId { get; set; }
        public uint CustomsAccountId { get; set; }
        public ulong SendAt { get; set; }
        public ulong? CompletedAt { get; set; }
        public byte? Page { get; set; }
        public string Status { get; set; } = null!;
        public string SendFiles { get; set; } = null!;
        public string? RealFaxFile { get; set; }
        public ulong Recipient { get; set; }
        public string? Extra { get; set; }
        public string Provider { get; set; } = null!;
        public uint DepartmentId { get; set; }
        public string? Source { get; set; }
    }
}
