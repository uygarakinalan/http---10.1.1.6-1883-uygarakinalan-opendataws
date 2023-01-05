using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class AksBagimsizBolum
    {
        public uint Id { get; set; }
        public ulong BinaNo { get; set; }
        public string IcKapiNo { get; set; } = null!;
        public ulong AdresNo { get; set; }
        public ulong? UpdatedAt { get; set; }
        public bool Aktif { get; set; }
        public uint? Kod { get; set; }
    }
}
