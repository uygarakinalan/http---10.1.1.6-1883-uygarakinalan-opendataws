using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class CustomerCallMeRequest
    {
        public uint Id { get; set; }
        public ulong CreatedAt { get; set; }
        public ulong? CustomerId { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public ulong PhoneNumber { get; set; }
        public string? EmailAddress { get; set; }
        public string? Source { get; set; }
        public bool IsRead { get; set; }
        public ulong? ResponsibleUserId { get; set; }
        public ulong? DepartmentId { get; set; }
        public ulong? DeletedAt { get; set; }
        public ulong? FacebookFormId { get; set; }
        public string? FacebookFormName { get; set; }
        public bool? IsCustomerExists { get; set; }
        public ulong? FacebookLeadgenId { get; set; }
        public ulong? FacebookAdId { get; set; }
        public string? FacebookAdName { get; set; }
        public ulong? FacebookAdsetId { get; set; }
        public string? FacebookAdsetName { get; set; }
        public ulong? FacebookCampaignId { get; set; }
        public string? FacebookCampaignName { get; set; }
        public string? Usource { get; set; }
        public string? Umedium { get; set; }
        public string? Ucampaign { get; set; }
        public string? Igclid { get; set; }
        public string? Ireferrer { get; set; }
        public string? Ilandpage { get; set; }
        public ulong? FacebookLeadgenTime { get; set; }
        public uint? CustomerActivityId { get; set; }
    }
}
