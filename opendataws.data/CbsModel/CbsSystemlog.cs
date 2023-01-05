using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsSystemlog
    {
        public int LogId { get; set; }
        public string? LogIp { get; set; }
        public string? LogBrowserInfo { get; set; }
        public string? LogAciklama { get; set; }
        public DateTime? LogTarih { get; set; }
        public int? LogKulId { get; set; }
        public string? LogTur { get; set; }
        public string? LogModulName { get; set; }
        public string? LogWkt { get; set; }
    }
}
