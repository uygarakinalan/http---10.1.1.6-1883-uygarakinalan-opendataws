using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class QmOption
    {
        public uint Id { get; set; }
        public string Title { get; set; } = null!;
        public int Score { get; set; }
        public ulong QuestionId { get; set; }
        public ulong CreatedAt { get; set; }
        public ulong? UpdatedAt { get; set; }
        public ulong? DeletedAt { get; set; }
        public bool? AbsorbingElement { get; set; }
        public int? OldId { get; set; }
    }
}
