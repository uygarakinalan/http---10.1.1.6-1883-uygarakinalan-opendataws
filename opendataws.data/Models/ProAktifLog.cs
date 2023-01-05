using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class ProAktifLog
    {
        public uint Id { get; set; }
        public ulong IncidentId { get; set; }
        public string? Request { get; set; }
        public string? Response { get; set; }
        public string? Status { get; set; }
        public ulong? ReturnIsEmriNo { get; set; }
        public ulong? ReturnIsEmriId { get; set; }
        public ulong CreatedAt { get; set; }
    }
}
