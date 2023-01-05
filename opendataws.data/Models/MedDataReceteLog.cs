using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class MedDataReceteLog
    {
        public uint Id { get; set; }
        public int SiraNo { get; set; }
        public string GssReceteNo { get; set; } = null!;
        public ulong CepTel { get; set; }
    }
}
