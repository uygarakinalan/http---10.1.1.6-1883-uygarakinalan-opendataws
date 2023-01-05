using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class SokakCadde
    {
        public int SokakCaddeId { get; set; }
        public string SokakCaddeTitle { get; set; } = null!;
        public int SokakCaddeMahallekey { get; set; }
        public ulong? CsbmKod { get; set; }
        public string? CsbmTipi { get; set; }
        public bool? Aktif { get; set; }
        public ulong? ControlledAt { get; set; }
    }
}
