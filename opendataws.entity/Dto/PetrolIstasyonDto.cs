using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace opendataws.entity.Dto
{
    public class PetrolIstasyonDto
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string IstasyonTuru { get; set; }
        public string Adres { get; set; }
        public string IlceAdi { get; set; }
        public string IstasyonDurumu { get; set; }

    }
}