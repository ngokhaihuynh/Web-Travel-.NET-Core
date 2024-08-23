using System;
using System.Collections.Generic;

#nullable disable

namespace WebDuLich.Models
{
    public partial class News
    {
        public int PostId { get; set; }
        public string Tile { get; set; }
        public string ShortContent { get; set; }
        public string Contents { get; set; }
        public string Image { get; set; }
        public bool? Publish { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Author { get; set; }
        public int? CatId { get; set; }
        public int? AccId { get; set; }
        public string Tags { get; set; }
        public bool? IsHot { get; set; }
        public bool? IsNewFeed { get; set; }
        public string MetaDesc { get; set; }
        public string MetaKey { get; set; }
        public int? Views { get; set; }

        public virtual Account Acc { get; set; }
        public virtual Category Cat { get; set; }
    }
}
