using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class HospitalPatientCall
    {
        public uint Id { get; set; }
        public ulong HospitalPatientId { get; set; }
        public ulong HbysAppointmentId { get; set; }
        public string? CallType { get; set; }
        public string? CallRecord { get; set; }
        public string CallStatus { get; set; } = null!;
        public string? CallResult { get; set; }
        public int CallCount { get; set; }
        public ulong? DeletedAt { get; set; }
        public ulong? UpdatedAt { get; set; }
        public ulong? CreatedAt { get; set; }
        public string? Note { get; set; }
        public uint? TelewebDoCallLogId { get; set; }
    }
}
