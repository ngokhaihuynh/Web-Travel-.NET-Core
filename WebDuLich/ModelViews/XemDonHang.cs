using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebDuLich.Models;

namespace WebDuLich.ModelViews
{
    public class XemDonHang
    {
        public Order DonHang { get; set; }
        public List<Orderdetail> ChiTietDonHang { get; set; }
    }
}
