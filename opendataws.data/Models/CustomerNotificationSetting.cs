using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class CustomerNotificationSetting
    {
        public uint Id { get; set; }
        public string CustomerAction { get; set; } = null!;
        public string Target { get; set; } = null!;
        public string Text { get; set; } = null!;
        public bool? Active { get; set; }
        public ulong? DeletedAt { get; set; }
    }
}
