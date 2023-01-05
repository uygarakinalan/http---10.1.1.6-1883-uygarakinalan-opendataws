using System;
using System.Collections.Generic;

namespace opendataws.data.MezarlikModels
{
    public partial class TekilMezarlik
    {
        public TekilMezarlik()
        {
            Kisilers = new HashSet<Kisiler>();
        }

        public int Id { get; set; }
        public string? TcKimlikNo { get; set; }
        public string Adi { get; set; } = null!;
        public string Soyadi { get; set; } = null!;
        public DateTime? DogumTarihi { get; set; }
        public string? Mahalle { get; set; }
        public decimal? Bedel { get; set; }
        public string? MakbuzNo { get; set; }
        public DateTime? MakbuzTarihi { get; set; }
        public string? Telefon { get; set; }
        public string? Ada { get; set; }
        public string? Gecit { get; set; }
        public string? Cadde { get; set; }
        public string? Aciklama { get; set; }
        public int? KisilerId { get; set; }
        public byte? MezarliklarId { get; set; }
        public int? EskiId { get; set; }
        public int? DefinId { get; set; }
        public bool? Ucretsiz { get; set; }
        public bool? Dolu { get; set; }
        public string? Latlng1 { get; set; }
        public string? Latlng2 { get; set; }
        public string? Latlng3 { get; set; }
        public string? Latlng4 { get; set; }
        public short? Ekleyen { get; set; }
        public DateTime? EklemeTarihi { get; set; }
        public short? Guncelleyen { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public bool? Aktif { get; set; }

        public virtual ICollection<Kisiler> Kisilers { get; set; }
    }
}
