using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class UserFastAnswer
    {
        public uint Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Text { get; set; } = null!;
        public uint UserId { get; set; }
        public uint? DeletedAt { get; set; }
    }
}
