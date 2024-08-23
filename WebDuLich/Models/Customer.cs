using System;
using System.Collections.Generic;

#nullable disable

namespace WebDuLich.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public int CusId { get; set; }
        public string FullName { get; set; }
        public DateTime? Birthday { get; set; }
        public string Avata { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int? LocationId { get; set; }
        public int? District { get; set; }
        public int? Ward { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Password { get; set; }
        public string Encode { get; set; }
        public DateTime? LastLogin { get; set; }
        public bool? Active { get; set; }
        public string Salt { get; set; }
        public virtual Location Location { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
