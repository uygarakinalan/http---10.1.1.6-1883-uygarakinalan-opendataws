using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class EdevletIncidentFaxis
    {
        public uint Id { get; set; }
        public ulong IncidentNumber { get; set; }
        public string Fax { get; set; } = null!;
    }
}
