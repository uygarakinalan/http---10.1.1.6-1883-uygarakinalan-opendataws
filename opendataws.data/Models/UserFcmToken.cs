using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class UserFcmToken
    {
        public uint Id { get; set; }
        public uint UserId { get; set; }
        public string Token { get; set; } = null!;
        public string? DeviceInfo { get; set; }
        public uint? DeletedAt { get; set; }
        public string? TokenSource { get; set; }
        public bool IsUlakfon { get; set; }
    }
}
