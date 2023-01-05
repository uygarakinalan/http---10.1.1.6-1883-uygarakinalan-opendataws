using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class QmFormQuestion
    {
        public uint Id { get; set; }
        public string Title { get; set; } = null!;
        public ulong FormId { get; set; }
        public ulong CreatedAt { get; set; }
        public ulong? UpdatedAt { get; set; }
        public ulong? DeletedAt { get; set; }
        public string? Visibility { get; set; }
        public int? RelatedQuestion { get; set; }
        public int? RelatedAnswer { get; set; }
        public int? OldId { get; set; }
    }
}
