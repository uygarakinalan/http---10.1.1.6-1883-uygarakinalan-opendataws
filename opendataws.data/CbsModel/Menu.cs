using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class Menu
    {
        public int MenuId { get; set; }
        public string? MenuText { get; set; }
        public string? MenuUrl { get; set; }
        public int? MenuRootId { get; set; }
        public string? MenuIcon { get; set; }
        public int? MenuSira { get; set; }
        /// <summary>
        /// 0= gizli 1 = görünür
        /// </summary>
        public int? MenuGorunurluk { get; set; }
        public int? MenuSil { get; set; }
        public string? MenuIconRenk { get; set; }
    }
}
