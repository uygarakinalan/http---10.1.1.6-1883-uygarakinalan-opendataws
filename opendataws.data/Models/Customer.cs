using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class Customer
    {
        public uint Id { get; set; }
        public uint? Number { get; set; }
        public uint CreatorUserId { get; set; }
        public string? Address { get; set; }
        public sbyte? IlId { get; set; }
        public short? IlceId { get; set; }
        public int? MahalleId { get; set; }
        public int? SokakId { get; set; }
        public ulong? MobilePhone { get; set; }
        public ulong? WorkPhone { get; set; }
        public ulong? HomePhone { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public ulong? IdentificationNumber { get; set; }
        public ulong CreatedAt { get; set; }
        public ulong? UpdatedAt { get; set; }
        public uint? Source { get; set; }
        public string Status { get; set; } = null!;
        public ulong? MobilePhone2 { get; set; }
        public ulong? ProjectNumber { get; set; }
        public long? Birthdate { get; set; }
        public string? Gender { get; set; }
        public string? MaritialStatus { get; set; }
        public uint? Profession { get; set; }
        public uint? LastUpdatedUserId { get; set; }
        public uint? ResponsibleUserId { get; set; }
        public uint? ResponsibleDepartmentId { get; set; }
        public ulong? DeletedAt { get; set; }
        public string? CustomerType { get; set; }
        public uint? WhereCustomerHearId { get; set; }
        public bool? AdPermission { get; set; }
        public string? AdPermissionValue { get; set; }
        public bool TasarrufRepresentetive { get; set; }
        public ulong? ReferencedCustomerId { get; set; }
        public string PersonType { get; set; } = null!;
        public string? CompanyTitle { get; set; }
        public uint? TaxNumber { get; set; }
        public string? ForeignIdentificationNumber { get; set; }
        public int? LastProjectNumber { get; set; }
        public bool? IsUser { get; set; }
    }
}
