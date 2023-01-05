using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class ViewGidaYardimiValilikDagitim
    {
        public int Id { get; set; }
        public int? GidaYardimValilikId { get; set; }
        public int? SiraNo { get; set; }
        public long? SatirNo { get; set; }
        public string? BasvuranTcNo { get; set; }
        public string? BasvuranAd { get; set; }
        public string? BasvuranSoyad { get; set; }
        public string? BasvuranCepTelefonu { get; set; }
        public string? BeyanIlceKod { get; set; }
        public string? BeyanMahKod { get; set; }
        public string? BeyanAcikAdres { get; set; }
        public string? NviAcikAdres { get; set; }
    }
}
