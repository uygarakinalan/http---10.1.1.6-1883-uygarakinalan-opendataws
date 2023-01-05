using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class GbbContact
    {
        public uint Id { get; set; }
        public string AdiSoyadi { get; set; } = null!;
        public ulong TcNo { get; set; }
        public ulong CepTelefonu { get; set; }
    }
}
