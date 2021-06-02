using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Admin_DangKyMonHoc.ModelsClass
{
    class SinhVien
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
    }
}
