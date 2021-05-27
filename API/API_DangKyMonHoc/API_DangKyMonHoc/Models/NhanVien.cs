using System;
using System.Collections.Generic;

#nullable disable

namespace API_DangKyMonHoc.Models
{
    public partial class NhanVien
    {
        public string MaNv { get; set; }
        public string TenNv { get; set; }
        public string EmailNv { get; set; }
        public string SdtNv { get; set; }
        public DateTime? NgaysinhNv { get; set; }
        public string Chucvu { get; set; }
        public string MatKhau { get; set; }
        public bool? Trangthai { get; set; }
    }
}
