using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class ViewMenuYetki
    {
        public int? SubMenuCount { get; set; }
        public int YetkiId { get; set; }
        public int? MenuId { get; set; }
        public int? KulId { get; set; }
        public int? YetkiInsert { get; set; }
        public int? YetkiDelete { get; set; }
        public int? YetkiUpdate { get; set; }
        public int? YetkiSelect { get; set; }
        public string? MenuText { get; set; }
        public string? MenuUrl { get; set; }
        public int? MenuRootId { get; set; }
        public string? MenuIcon { get; set; }
        public int? MenuSira { get; set; }
        public string? KulAdiSoyadi { get; set; }
        public string? KulAdi { get; set; }
        public int? MenuGorunurluk { get; set; }
        public string? MenuIconRenk { get; set; }
        public int? MenuSil { get; set; }
        public int? Durum { get; set; }
    }
}
