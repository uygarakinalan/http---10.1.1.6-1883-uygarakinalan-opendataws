using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class SoforDurum
    {
        public uint Id { get; set; }
        public uint UserId { get; set; }
        public uint IncidentId { get; set; }
        public bool Status { get; set; }
    }
}
