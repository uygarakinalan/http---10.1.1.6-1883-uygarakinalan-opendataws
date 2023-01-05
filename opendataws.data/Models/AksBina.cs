using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class AksBina
    {
        public uint Id { get; set; }
        public ulong BinaNo { get; set; }
        public string DisKapiNo { get; set; } = null!;
        public int CsbmKodu { get; set; }
        public string? BlokAdi { get; set; }
        public ulong? UpdatedAt { get; set; }
        public bool Aktif { get; set; }
        public string? BinaYapiTipi { get; set; }
        public string? BinaNumarajTipi { get; set; }
        public string? BinaDurum { get; set; }
        public uint? Kod { get; set; }
        public string? Enlem { get; set; }
        public string? Boylam { get; set; }
        public ulong? ControlledAt { get; set; }
    }
}
