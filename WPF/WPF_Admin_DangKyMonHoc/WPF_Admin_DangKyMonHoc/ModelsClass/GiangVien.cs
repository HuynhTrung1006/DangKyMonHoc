using System;
using System.Collections.Generic;



namespace WPF_Admin_DangKyMonHoc.ModelsClass
{
    public partial class GiangVien
    {
        public string MaGv { get; set; }
        public string TenGv { get; set; }
        public string Diachi { get; set; }
        public DateTime? Ngaysinh { get; set; }
        public string HocHam { get; set; }
        public bool? Phai { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }
        public string Chucvu { get; set; }
        public string MaKhoa { get; set; }

        public virtual Khoa MaKhoaNavigation { get; set; }
    }
}
