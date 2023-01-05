using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class CustomerProjectLeaf
    {
        public uint Id { get; set; }
        public ulong LeaveDate { get; set; }
        public ulong RefundDate { get; set; }
        public decimal RefundAmount { get; set; }
        public decimal DeductionAmount { get; set; }
        public string AccountInfo { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public ulong ProjectId { get; set; }
        public uint? CustomerProjectActionId { get; set; }
        public uint? DeletedAt { get; set; }
    }
}
