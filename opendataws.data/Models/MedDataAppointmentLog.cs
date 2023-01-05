using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class MedDataAppointmentLog
    {
        public uint Id { get; set; }
        public uint UserId { get; set; }
        public string? Uid { get; set; }
        public string Action { get; set; } = null!;
        public uint SiraNo { get; set; }
        public uint? BolumId { get; set; }
        public uint? DrId { get; set; }
        public bool IsSuccess { get; set; }
        public ulong CreatedAt { get; set; }
    }
}
