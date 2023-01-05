﻿using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class IncidentTopicGroup
    {
        public uint Id { get; set; }
        public string Title { get; set; } = null!;
        public ulong CreatedAt { get; set; }
        public ulong? DeletedAt { get; set; }
    }
}
