using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class IncidentShortUrl
    {
        public uint Id { get; set; }
        public uint IncidentId { get; set; }
        public string ShortUrl { get; set; } = null!;
    }
}
