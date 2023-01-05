using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace opendataws.entity.Dto
{
    public class ItfaiyeEgitimDto
    {
        public DateTime? EgitimTarihi { get; set; }
        public string EgitimKonusu { get; set; }
        public string YasGrubu { get; set; }
        public string Ilce { get; set; }
        public int? ErkekKatilimci { get; set; }
        public int? KadinKatilimci { get; set; }

    }
}