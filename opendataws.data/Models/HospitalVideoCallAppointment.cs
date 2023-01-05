using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class HospitalVideoCallAppointment
    {
        public uint Id { get; set; }
        public uint AppointmentDate { get; set; }
        public string? AppointmentInfo { get; set; }
        public string DoctorToken { get; set; } = null!;
        public string? DoctorStatus { get; set; }
        public string? DoctorCallResult { get; set; }
        public ulong DoctorPhoneNumber { get; set; }
        public string PatientToken { get; set; } = null!;
        public string? PatientStatus { get; set; }
        public string? PatientCallResult { get; set; }
        public ulong PatientPhoneNumber { get; set; }
        public string? VideoCallStatus { get; set; }
    }
}
