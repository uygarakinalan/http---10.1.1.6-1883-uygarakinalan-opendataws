using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class GencGaziantepKullanicilar
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Tc { get; set; }
        public string? Phone { get; set; }
        public DateTime? Birthday { get; set; }
        public byte? Gender { get; set; }
        public string? Email { get; set; }
        public int? Referrer { get; set; }
        public int? IsActive { get; set; }
        public DateTime? LastLogin { get; set; }
        public string? YokOkulu { get; set; }
        public string? NviSehir { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? NviIlce { get; set; }
        public string? NviMahalle { get; set; }
        public int? NviIlceKodu { get; set; }
        public int? NviMahalleKodu { get; set; }
    }
}
