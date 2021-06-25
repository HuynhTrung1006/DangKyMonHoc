using System;
using System.Collections.Generic;

#nullable disable

namespace API_DangKyMonHoc.Models
{
    public partial class PhieuDangKy
    {
        public PhieuDangKy()
        {
            ChiTietPdks = new HashSet<ChiTietPdk>();
        }

        public string MaPdk { get; set; }
        public DateTime Ngaylap { get; set; }
        public DateTime? Ngaychinhsua { get; set; }
        public string MaSv { get; set; }

        public virtual SinhVien MaSvNavigation { get; set; }
        public virtual BangDiem BangDiem { get; set; }
        public virtual ICollection<ChiTietPdk> ChiTietPdks { get; set; }
    }
}
