using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class CustomerTasarrufProjectCalculation
    {
        public uint Id { get; set; }
        public ulong? CreatedAt { get; set; }
        public ulong? PlanSelectedAt { get; set; }
        public ulong? SavedAt { get; set; }
        public string? PublicToken { get; set; }
        public string? SelectedPlanToken { get; set; }
        public uint UserId { get; set; }
        public uint? CustomerId { get; set; }
        public string Request { get; set; } = null!;
        public string Response { get; set; } = null!;
        public uint? SelectedPlanId { get; set; }
        public uint? CustomerProjectId { get; set; }
        public uint? GroupId { get; set; }
    }
}
