using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class HospitalAppointment
    {
        public uint Id { get; set; }
        public ulong HbysAppointmentId { get; set; }
        public ulong HbysDoctorId { get; set; }
        public ulong HbysDepartmentId { get; set; }
        public ulong Time { get; set; }
        public ulong? DeletedAt { get; set; }
        public ulong? UpdatedAt { get; set; }
        public ulong? CreatedAt { get; set; }
    }
}
