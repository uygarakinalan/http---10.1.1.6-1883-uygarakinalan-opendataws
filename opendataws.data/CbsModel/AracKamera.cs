using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class AracKamera
    {
        public int Id { get; set; }
        public string? PlateNo { get; set; }
        public string? Link { get; set; }
        public int? KameraNo { get; set; }
        public string? DeviceId { get; set; }
        public bool? Active { get; set; }
    }
}
