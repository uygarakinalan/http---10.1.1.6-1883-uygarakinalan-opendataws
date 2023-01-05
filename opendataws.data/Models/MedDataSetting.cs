﻿using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class MedDataSetting
    {
        public uint Id { get; set; }
        public string Key { get; set; } = null!;
        public string Value { get; set; } = null!;
    }
}
