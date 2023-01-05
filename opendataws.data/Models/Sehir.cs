using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class Sehir
    {
        public int SehirId { get; set; }
        public string SehirTitle { get; set; } = null!;
        public int SehirKey { get; set; }
    }
}
