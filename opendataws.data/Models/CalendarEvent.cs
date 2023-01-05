using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class CalendarEvent
    {
        public uint Id { get; set; }
        public uint UserId { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public ulong StartDate { get; set; }
        public ulong EndDate { get; set; }
        public int? LabelId { get; set; }
        public ulong CreatedAt { get; set; }
        public ulong? DeletedAt { get; set; }
        public ushort? IlceId { get; set; }
        public uint? MahalleId { get; set; }
        public ulong? SokakId { get; set; }
        public uint? BinaNo { get; set; }
        public ulong? AdresNo { get; set; }
        public string? GeogrophicCoordinate { get; set; }
        public string? RepeatSetting { get; set; }
        public string? RepetitionDays { get; set; }
        public ulong? RepeatEndDate { get; set; }
        public string? MainEventId { get; set; }
        public string? Priority { get; set; }
        public string? Attachments { get; set; }
    }
}
