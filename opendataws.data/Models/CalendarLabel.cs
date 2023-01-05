using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class CalendarLabel
    {
        public uint Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; } = null!;
        public string TextColor { get; set; } = null!;
        public string BackgroundColor { get; set; } = null!;
        public ulong CreatedAt { get; set; }
        public ulong? DeletedAt { get; set; }
    }
}
