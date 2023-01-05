using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsUpload
    {
        public int UploadId { get; set; }
        public string? UploadFilename { get; set; }
        public string? UploadPath { get; set; }
        public string? DosyaTuru { get; set; }
        public string? OzelKod1 { get; set; }
        public string? OzelKod2 { get; set; }
        public string? DosyaAdi { get; set; }
    }
}
