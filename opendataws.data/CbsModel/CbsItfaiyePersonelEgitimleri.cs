using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class CbsItfaiyePersonelEgitimleri
    {
        public int Id { get; set; }
        public int? PersonelId { get; set; }
        public int? EgitimTurId { get; set; }
        public DateTime? EgitimTarihi { get; set; }
        public DateTime? EgitimBaslangisTarihi { get; set; }
        public DateTime? EgitimBitisTarihi { get; set; }
        public string? EgitimSuresi { get; set; }
        public string? EgitimBasariDurumu { get; set; }
        public DateTime? SertifikaTarihi { get; set; }
        public string? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? GuncelleyenUserId { get; set; }
        public string? EgitimVerenKurum { get; set; }
        public string? EgitimYeri { get; set; }
    }
}
