using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class HospitalDoctor
    {
        public uint Id { get; set; }
        public ulong HbysDoctorId { get; set; }
        public string FullName { get; set; } = null!;
        public ulong? PhoneNumber { get; set; }
        public bool? AppointmentReminder { get; set; }
        public bool? EvaluationReminder { get; set; }
        public ulong? DeletedAt { get; set; }
        public ulong? UpdatedAt { get; set; }
        public ulong CreatedAt { get; set; }
    }
}
