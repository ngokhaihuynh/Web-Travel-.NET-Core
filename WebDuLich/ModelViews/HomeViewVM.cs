using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebDuLich.Models;

namespace WebDuLich.ModelViews
{
    public class HomeViewVM
    {
       
        public List<News> news { get; set; }
        public List<ProductHomeVM> Products { get; set; }

        public List<Product> FilteredProducts { get; set; } 

    }
}
