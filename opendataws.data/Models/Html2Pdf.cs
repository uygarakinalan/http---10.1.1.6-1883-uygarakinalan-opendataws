using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class Html2Pdf
    {
        public uint Id { get; set; }
        public uint UserId { get; set; }
        public string Hash { get; set; } = null!;
        public string? Html { get; set; }
        public string Filename { get; set; } = null!;
        public ulong CreatedAt { get; set; }
        public string IpAddr { get; set; } = null!;
    }
}
