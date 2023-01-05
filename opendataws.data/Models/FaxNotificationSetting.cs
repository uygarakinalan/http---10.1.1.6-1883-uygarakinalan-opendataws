using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class FaxNotificationSetting
    {
        public uint Id { get; set; }
        public string Text { get; set; } = null!;
        public string? Action { get; set; }
        public bool SendFile { get; set; }
        public bool IsActive { get; set; }
        public ulong CreatedAt { get; set; }
    }
}
