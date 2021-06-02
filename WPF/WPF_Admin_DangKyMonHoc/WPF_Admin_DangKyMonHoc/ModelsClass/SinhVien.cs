using System;
using System.Collections.Generic;


namespace WPF_Admin_DangKyMonHoc.ModelsClass
{
    public partial class SinhVien
    {
        public string MsSv { get; set; }
        public string TenSv { get; set; }
        public string Diachi { get; set; }
        public DateTime? Ngaysinh { get; set; }
        public bool? Phai { get; set; }
        public string Email { get; set; }
        public string Cmnd { get; set; }
        public string Hedaotao { get; set; }
        public string Matkhau { get; set; }
        public bool? Trangthai { get; set; }
        public string MaKhoa { get; set; }
        public string MaLop { get; set; }

        public virtual Khoa MaKhoaNavigation { get; set; }
        public virtual Lop MaLopNavigation { get; set; }
    }
}
