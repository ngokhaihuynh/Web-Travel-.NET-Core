using System;
using System.Collections.Generic;

#nullable disable

namespace WebDuLich.Models
{
    public partial class Tintuc
    {
        public long IdTinTuc { get; set; }
        public string HinhAnhTt { get; set; }
        public DateTime? ThoiGianTt { get; set; }
        public string TacGia { get; set; }
        public string NoiDung { get; set; }
    }
}
