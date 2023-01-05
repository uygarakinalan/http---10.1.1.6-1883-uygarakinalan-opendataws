using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class Pano
    {
        public uint Id { get; set; }
        public string Title { get; set; } = null!;
        public string Url { get; set; } = null!;
        public sbyte IsMobile { get; set; }
        public ulong CreatedAt { get; set; }
        public ulong? UpdatedAt { get; set; }
        public sbyte LimitWithVisibleDepartments { get; set; }
    }
}
