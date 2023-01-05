using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class HospitalPatientAppointment
    {
        public uint Id { get; set; }
        public ulong PatientId { get; set; }
        public ulong AppointmentId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
