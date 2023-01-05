using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class UserGroupRelation
    {
        public uint Id { get; set; }
        public uint UserId { get; set; }
        public uint GroupId { get; set; }
    }
}
