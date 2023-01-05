using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace opendataws.webapi.Model.FromApi
{
    public class GetData
    {
        public string point { get; set; }
        public  DateTime baslangicTarihi { get; set; }
        public DateTime bitisTarihi { get; set; }
    }
}