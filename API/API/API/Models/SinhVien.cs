using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class SinhVien
    {
        public SinhVien()
        {
            PhieuDangKies = new HashSet<PhieuDangKy>();
            PhucKhaos = new HashSet<PhucKhao>();
        }

        public string MaSv { get; set; }
        public string TenSv { get; set; }
        public string Diachi { get; set; }
        public DateTime Ngaysinh { get; set; }
        public bool Phai { get; set; }
        public string Email { get; set; }
        public string Cnmd { get; set; }
        public string Hinhanh { get; set; }
        public string Matkhau { get; set; }
        public string MaLop { get; set; }

        public virtual Lop MaLopNavigation { get; set; }
        public virtual ICollection<PhieuDangKy> PhieuDangKies { get; set; }
        public virtual ICollection<PhucKhao> PhucKhaos { get; set; }
    }
}
