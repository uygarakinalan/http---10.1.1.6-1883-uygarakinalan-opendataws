using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class ValilikDilenciSonuclanirmaTurleri
    {
        public int SonuclandirmaTuruId { get; set; }
        public string? SonuclandirmaTuru { get; set; }
        public int? Durum { get; set; }
        public int? KurumId { get; set; }
    }
}
