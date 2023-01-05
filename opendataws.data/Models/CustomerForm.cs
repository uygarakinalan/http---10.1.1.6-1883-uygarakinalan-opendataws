using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class CustomerForm
    {
        public uint Id { get; set; }
        public string DefaultFields { get; set; } = null!;
    }
}
