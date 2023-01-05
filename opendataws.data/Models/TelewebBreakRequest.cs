using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class TelewebBreakRequest
    {
        public uint Id { get; set; }
        public ulong UserId { get; set; }
        public ulong? ManagerUserId { get; set; }
        public string SelectedBreakOption { get; set; } = null!;
        public string? RequestText { get; set; }
        public string? ResponseText { get; set; }
        public string? Status { get; set; }
        public string? BreakTimes { get; set; }
        public uint? TelewebQueue { get; set; }
        public ulong? ClosedAt { get; set; }
        public ulong? PerformedAt { get; set; }
        public ulong CreatedAt { get; set; }
    }
}
