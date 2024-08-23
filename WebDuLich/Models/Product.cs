using System;
using System.Collections.Generic;

#nullable disable

namespace WebDuLich.Models
{
    public partial class Product
    {
        public Product()
        {
            Orderdetails = new HashSet<Orderdetail>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ShortDesc { get; set; }
        public string Description { get; set; }
        public int? CatId { get; set; }
        public int? Price { get; set; }
        public int? Discount { get; set; }
        public string Image { get; set; }
        public string Images { get; set; }
        public string Video { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? CreateModified { get; set; }
        public bool? BestSeller { get; set; }
        public bool? HomeFlag { get; set; }
        public bool? Actice { get; set; }
        public string Tags { get; set; }
        public string Title { get; set; }
        public string MetaDesc { get; set; }
        public string MetaKey { get; set; }
        public int? StockingTour { get; set; }
        public string thumb { get; set; }
        public string Address { get; set; }
        public virtual Category Cat { get; set; }
        public virtual ICollection<Orderdetail> Orderdetails { get; set; }
    }
}
