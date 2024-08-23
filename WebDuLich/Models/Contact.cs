using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDuLich.Models
{
    public partial class Contact
    {
        public int IdLienHe { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string Note { get; set; }
    }
}
