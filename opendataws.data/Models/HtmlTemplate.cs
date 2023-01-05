using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class HtmlTemplate
    {
        public uint Id { get; set; }
        public uint UserId { get; set; }
        public string? Html { get; set; }
        public string Title { get; set; } = null!;
        public string Location { get; set; } = null!;
        public ulong UpdatedAt { get; set; }
        public ulong CreatedAt { get; set; }
    }
}
