using System;
using System.Collections.Generic;

#nullable disable

namespace WebDuLich.Models
{
    public partial class Page
    {
        public int PageId { get; set; }
        public string PageName { get; set; }
        public string Contents { get; set; }
        public string Image { get; set; }
        public bool? Publish { get; set; }
        public string Title { get; set; }
        public string MetaDesc { get; set; }
        public string MetaKey { get; set; }
        public string Alias { get; set; }
        public DateTime? CreatDate { get; set; }
    }
}
