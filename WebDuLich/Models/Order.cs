using System;
using System.Collections.Generic;

#nullable disable

namespace WebDuLich.Models
{
    public partial class Order
    {
        public Order()
        {
            Orderdetails = new HashSet<Orderdetail>();
        }

        public int OrderId { get; set; }
        //public int LocationId { get; set; }
        public int? CusId { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? ShipDate { get; set; }
        public int? TransactId { get; set; }
        public string Status { get; set; }
        public bool? Deteled { get; set; }
        public bool? Paid { get; set; }
        public DateTime? PaymentDate { get; set; }
      
        public int? PaymentId { get; set; }
        public string Note { get; set; }
        public int TotalMoney { get; set; }
        public string Address { get; set; }
        public int? District { get; set; }
        public int? Ward { get; set; }
        public DateTime? NgayDi { get; set; }
        public virtual Customer Cus { get; set; }
        public virtual Location Location { get; set; }
        public virtual Transactstatus Transact { get; set; }
        public virtual ICollection<Orderdetail> Orderdetails { get; set; }
    }
}
