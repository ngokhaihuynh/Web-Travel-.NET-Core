using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebDuLich.Models;

namespace WebDuLich.ModelViews
{
    public class CartItem
    {
        
        public Product product { get; set; }
        public int amount { get; set; }
        public double TotalMoney => amount * product.Price.Value;
    }
}
