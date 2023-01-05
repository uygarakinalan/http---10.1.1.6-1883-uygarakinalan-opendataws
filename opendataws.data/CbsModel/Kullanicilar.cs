using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class Kullanicilar
    {
        public Kullanicilar()
        {
            CbsTapuLogs = new HashSet<CbsTapuLog>();
        }

        public int KulId { get; set; }
        public string? KulAdi { get; set; }
        public string? KulSifre { get; set; }
        public string? KulEmail { get; set; }
        public string? KulAdiSoyadi { get; set; }
        public int? KulGrup { get; set; }
        public DateTime? KulSongiris { get; set; }
        public int? PerId { get; set; }
        /// <summary>
        /// 1= aktif , 0 = pasif
        /// </summary>
        public int? Durum { get; set; }
        public int? BirimId { get; set; }
        public int? AltBirimId { get; set; }
        public int? KulGirisDurumu { get; set; }
        public string? KulIp { get; set; }
        public int? KurumId { get; set; }
        public int? MuhtarId { get; set; }
        public int? MahalleTemsilciId { get; set; }
        public string? KulTc { get; set; }
        public int? KaydedenUserId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int? GuncelleyenUserId { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public int? KulGorevId { get; set; }
        public string? KulTelefon { get; set; }
        public string? LdapKullaniciAdi { get; set; }

        public virtual ICollection<CbsTapuLog> CbsTapuLogs { get; set; }
    }
}
