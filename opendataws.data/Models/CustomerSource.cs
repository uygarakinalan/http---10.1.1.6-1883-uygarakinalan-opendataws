using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class CustomerSource
    {
        public uint Id { get; set; }
        public string Title { get; set; } = null!;
        public string ImportToken { get; set; } = null!;
    }
}
