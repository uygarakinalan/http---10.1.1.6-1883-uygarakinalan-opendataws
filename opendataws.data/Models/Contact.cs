using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class Contact
    {
        public uint Id { get; set; }
        public ulong? IdentificationNumber { get; set; }
        public string Name { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string FathersName { get; set; } = null!;
        public string MothersName { get; set; } = null!;
        public byte BirthDay { get; set; }
        public byte BirthMonth { get; set; }
        public short BirthYear { get; set; }
        public string Address { get; set; } = null!;
        public ulong? AdresNo { get; set; }
        public byte? IlKodu { get; set; }
        public uint? IlceKodu { get; set; }
        public uint? MahalleKodu { get; set; }
        public uint? CsbmKodu { get; set; }
        public string? DisKapiNo { get; set; }
        public string? IcKapiNo { get; set; }
        public uint UpdatedAt { get; set; }
        public uint CreatedAt { get; set; }
        public string? Gender { get; set; }
        public string? BirthPlace { get; set; }
        public uint? EducationStatusId { get; set; }
        public string? DocumentNo { get; set; }
        public ulong? BinaNo { get; set; }
        public bool? AllowSurveyCalls { get; set; }
    }
}
