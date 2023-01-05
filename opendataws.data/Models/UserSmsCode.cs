using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class UserSmsCode
    {
        public uint Id { get; set; }
        public uint Code { get; set; }
        public uint UserId { get; set; }
        public uint SendAt { get; set; }
        public string? SmsResponse { get; set; }
        public bool Used { get; set; }
    }
}
