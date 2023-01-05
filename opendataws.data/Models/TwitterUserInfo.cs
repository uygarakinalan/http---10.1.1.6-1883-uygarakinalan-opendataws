using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class TwitterUserInfo
    {
        public uint Id { get; set; }
        public ulong UserId { get; set; }
        public int Follower { get; set; }
        public int Followed { get; set; }
        public int NumberOfTweets { get; set; }
        public bool Verified { get; set; }
        public ulong CreatedAt { get; set; }
        public ulong UpdatedAt { get; set; }
        public string? Description { get; set; }
        public string? Location { get; set; }
        public string? ProfilePic { get; set; }
    }
}
