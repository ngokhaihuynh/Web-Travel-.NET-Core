using System;
using System.Collections.Generic;

#nullable disable

namespace WebDuLich.Models
{
    public partial class Category
    {
        public Category()
        {
            News = new HashSet<News>();
            Products = new HashSet<Product>();
        }

        public int CatId { get; set; }
        public string CatName { get; set; }
        public string Description { get; set; }
        public int? ParentId { get; set; }
        public int? Levels { get; set; }
        public int? Location { get; set; }
        public bool? Publish { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }

        public virtual ICollection<News> News { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
