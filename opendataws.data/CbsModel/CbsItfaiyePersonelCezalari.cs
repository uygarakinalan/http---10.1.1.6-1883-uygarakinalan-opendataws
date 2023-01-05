using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsItfaiyePersonelCezalari
    {
        public int Id { get; set; }
        public int? PersonelId { get; set; }
        public int? CezaTurId { get; set; }
        public DateTime? CezaTebligTarihi { get; set; }
        public DateTime? CezaBaslangisTarihi { get; set; }
        public DateTime? CezaBitisTarihi { get; set; }
        public string? CezaAciklama { get; set; }
        public string? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? GuncelleyenUserId { get; set; }
    }
}
