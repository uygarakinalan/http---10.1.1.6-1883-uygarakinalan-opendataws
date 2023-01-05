using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class CustomerPayment
    {
        public uint Id { get; set; }
        public uint ProjectId { get; set; }
        public int Number { get; set; }
        public ulong DueDate { get; set; }
        public decimal? Amount { get; set; }
        public string PaymentStatus { get; set; } = null!;
        public ulong CreatedAt { get; set; }
        public string? PaymentType { get; set; }
        public uint? ResponsibleUserId { get; set; }
        public ulong? PaymentDate { get; set; }
        public decimal? AmountPaid { get; set; }
    }
}
