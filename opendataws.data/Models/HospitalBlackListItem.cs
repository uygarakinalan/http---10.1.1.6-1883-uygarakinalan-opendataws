using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class HospitalBlackListItem
    {
        public uint Id { get; set; }
        public ulong PhoneNumber { get; set; }
        public string? FullName { get; set; }
        public bool ExcludedFromAppointment { get; set; }
        public bool ExcludedFromEvaluation { get; set; }
        public ulong? DeletedAt { get; set; }
        public ulong? UpdatedAt { get; set; }
        public ulong CreatedAt { get; set; }
    }
}
