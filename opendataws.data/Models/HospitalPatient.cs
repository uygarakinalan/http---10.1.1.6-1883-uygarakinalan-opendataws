using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class HospitalPatient
    {
        public uint Id { get; set; }
        public string FullName { get; set; } = null!;
        public ulong? PhoneNumber { get; set; }
        public ulong? DeletedAt { get; set; }
        public ulong? UpdatedAt { get; set; }
        public ulong? CreatedAt { get; set; }
        public int? OriginalPatientId { get; set; }
    }
}
