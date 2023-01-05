﻿using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class IncidentPublicActionValidation
    {
        public uint Id { get; set; }
        public string? IncidentPublicToken { get; set; }
        public ulong MobilePhone { get; set; }
        public string ValidationCode { get; set; } = null!;
        public bool IsValid { get; set; }
        public string UserToken { get; set; } = null!;
        public string UserIp { get; set; } = null!;
        public string? UserAgent { get; set; }
        public ulong CreatedAt { get; set; }
        public byte ValidationAttemptCount { get; set; }
        public ulong? LastAttemptedAt { get; set; }
    }
}
