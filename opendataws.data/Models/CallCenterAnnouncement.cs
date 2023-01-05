using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class CallCenterAnnouncement
    {
        public uint Id { get; set; }
        public string? Description { get; set; }
        public string WhenActive { get; set; } = null!;
        public bool Active { get; set; }
        public ulong? StartDate { get; set; }
        public ulong? FinishDate { get; set; }
        public ulong? StartHour { get; set; }
        public ulong? FinishHour { get; set; }
        public string? SoundSource { get; set; }
        public string? SoundText { get; set; }
        public string? SoundFile { get; set; }
    }
}
