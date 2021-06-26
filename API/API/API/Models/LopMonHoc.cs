using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class LopMonHoc
    {
        public string MaLmh { get; set; }
        public string TenLmh { get; set; }
        public int Sisi { get; set; }
        public string MaCdk { get; set; }
        public string MaMh { get; set; }

        public virtual CongDangKy MaCdkNavigation { get; set; }
        public virtual MonHoc MaMhNavigation { get; set; }
        public virtual BangDiem BangDiem { get; set; }
        public virtual LopMonHocGiangVien LopMonHocGiangVien { get; set; }
    }
}
