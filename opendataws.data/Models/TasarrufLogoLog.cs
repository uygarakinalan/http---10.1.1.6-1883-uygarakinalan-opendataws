using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class TasarrufLogoLog
    {
        public uint Id { get; set; }
        public uint ProjectId { get; set; }
        public string? LogoFicheNumber { get; set; }
        public uint? LogoReferenceId { get; set; }
        public string? Request { get; set; }
        public ulong CreatedAt { get; set; }
        public string? PaymentType { get; set; }
        public string? Status { get; set; }
    }
}
