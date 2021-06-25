using System;
using System.Collections.Generic;

#nullable disable

namespace API_DangKyMonHoc.Models
{
    public partial class BangDiem
    {
        public int Id { get; set; }
        public string MaLmh { get; set; }
        public string MaPdk { get; set; }
        public bool Trangthai { get; set; }

        public virtual LopMonHoc MaLmhNavigation { get; set; }
        public virtual PhieuDangKy MaPdkNavigation { get; set; }
    }
}
