﻿using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class IncidentReadLog
    {
        public uint Id { get; set; }
        public ulong UserId { get; set; }
        public ulong IncidentId { get; set; }
    }
}
