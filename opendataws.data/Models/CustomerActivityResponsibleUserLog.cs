using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class CustomerActivityResponsibleUserLog
    {
        public uint Id { get; set; }
        public uint ActivityId { get; set; }
        public string Source { get; set; } = null!;
        public uint UserId { get; set; }
        public bool SetCustomerRespId { get; set; }
    }
}
