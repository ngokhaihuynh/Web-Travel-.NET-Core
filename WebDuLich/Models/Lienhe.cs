using System;
using System.Collections.Generic;

#nullable disable

namespace WebDuLich.Models
{
    public partial class Lienhe
    {
        public long IdLienHe { get; set; }
        public string HoTenKhachHang { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }
        public string NoiDung { get; set; }
    }
}
