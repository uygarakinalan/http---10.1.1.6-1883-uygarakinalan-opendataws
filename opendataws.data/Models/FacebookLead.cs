using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class FacebookLead
    {
        public uint Id { get; set; }
        public string Platform { get; set; } = null!;
        public ulong FormId { get; set; }
        public string FormName { get; set; } = null!;
        public ulong LeadId { get; set; }
        public ulong LeadTime { get; set; }
        public string FieldData { get; set; } = null!;
        public ulong AdId { get; set; }
        public ulong AdsetId { get; set; }
        public string AdName { get; set; } = null!;
        public string AdsetName { get; set; } = null!;
        public ulong CampaignId { get; set; }
        public string CampaignName { get; set; } = null!;
        public ulong CreatedAt { get; set; }
    }
}
