using System;
using System.Collections.Generic;

namespace opendataws.data.MezarlikModels
{
    public partial class TaziyeEviPlanlama
    {
        public int Id { get; set; }
        public int? TaziyeEviId { get; set; }
        public string? TcKimlikNo { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string? Telefon { get; set; }
        public DateTime? BaslangicTarihi { get; set; }
        public DateTime? BitisTarihi { get; set; }
        public string? Aciklama { get; set; }
        public short? Ekleyen { get; set; }
        public DateTime? EklemeTarihi { get; set; }
        public short? Guncelleyen { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public bool? Aktif { get; set; }
        public long? Version { get; set; }

        public virtual TaziyeEvleri? TaziyeEvi { get; set; }
    }
}
