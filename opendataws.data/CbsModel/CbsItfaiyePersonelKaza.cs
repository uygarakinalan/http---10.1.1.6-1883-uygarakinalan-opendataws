using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsItfaiyePersonelKaza
    {
        public int Id { get; set; }
        public int? PersonelId { get; set; }
        public int? KazaNedenId { get; set; }
        public DateTime? KazaTarihi { get; set; }
        public string? KazaAciklama { get; set; }
        public string? KazaBilgisi { get; set; }
        public string? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? GuncelleyenUserId { get; set; }
    }
}
