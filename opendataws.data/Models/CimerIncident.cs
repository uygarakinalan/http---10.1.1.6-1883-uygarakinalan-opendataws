using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class CimerIncident
    {
        public uint Id { get; set; }
        public ulong BasvuruSayisi { get; set; }
        public uint BasvuruId { get; set; }
        public ulong SevkId { get; set; }
        public string Data { get; set; } = null!;
        public ulong ImportedAt { get; set; }
        public bool IsUrlChecked { get; set; }
        public string Files { get; set; } = null!;
        public string Info { get; set; } = null!;
        public ulong CreatedIncidentNumber { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsAnswered { get; set; }
        public bool IsApproved { get; set; }
        public bool IsReturned { get; set; }
        public bool IsHeld { get; set; }
    }
}
