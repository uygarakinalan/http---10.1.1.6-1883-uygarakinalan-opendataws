using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class UserFaxInbox
    {
        public uint Id { get; set; }
        public uint UserId { get; set; }
        public uint FaxInboxId { get; set; }
        public uint? ReadAt { get; set; }
    }
}
