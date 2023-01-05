using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class HospitalPatientCallLog
    {
        public uint Id { get; set; }
        public string CentralLogId { get; set; } = null!;
        public string PatientCallId { get; set; } = null!;
        public string Status { get; set; } = null!;
        public ulong? DeletedAt { get; set; }
        public ulong? CreatedAt { get; set; }
    }
}
