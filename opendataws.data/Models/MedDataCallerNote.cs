using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class MedDataCallerNote
    {
        public uint Id { get; set; }
        public uint? DosyaNo { get; set; }
        public ulong? KimlikNo { get; set; }
        public ulong? Telefon { get; set; }
        public ulong UserId { get; set; }
        public ulong CreatedAt { get; set; }
        public string Text { get; set; } = null!;
        public DateTime? DeletedAt { get; set; }
    }
}
