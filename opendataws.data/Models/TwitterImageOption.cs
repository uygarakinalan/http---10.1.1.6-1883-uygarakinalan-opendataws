using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class TwitterImageOption
    {
        public uint Id { get; set; }
        public string Title { get; set; } = null!;
        public uint CustomsAccountsId { get; set; }
        public uint IncidentSourceId { get; set; }
        public string? IncidentTopicIds { get; set; }
        public string FontSize { get; set; } = null!;
        public string PageCountFontSize { get; set; } = null!;
        public string CharacterCount { get; set; } = null!;
        public string LineMaxCharacterCount { get; set; } = null!;
        public string? Image { get; set; }
        public string? ImageCordinates { get; set; }
        public string? PageCountCordinates { get; set; }
        public ulong CreatedAt { get; set; }
        public ulong? DeletedAt { get; set; }
    }
}
