using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class UserFeedback
    {
        public uint Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public uint UserId { get; set; }
        public string Text { get; set; } = null!;
    }
}
