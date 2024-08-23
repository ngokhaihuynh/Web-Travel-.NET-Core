using System;
using System.Collections.Generic;

#nullable disable

namespace WebDuLich.Models
{
    public partial class Transactstatus
    {
        public Transactstatus()
        {
            Orders = new HashSet<Order>();
        }

        public int TransactId { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
