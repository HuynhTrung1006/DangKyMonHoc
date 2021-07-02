using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class PhieuDangKy
    {
        public PhieuDangKy()
        {
            BangDiems = new HashSet<BangDiem>();
            ChiTietPdks = new HashSet<ChiTietPdk>();
        }

        public string MaPdk { get; set; }
        public DateTime Ngaylap { get; set; }
        public DateTime? Ngaychinhsua { get; set; }
        public string MaSv { get; set; }

        public virtual SinhVien MaSvNavigation { get; set; }
        public virtual ICollection<BangDiem> BangDiems { get; set; }
        public virtual ICollection<ChiTietPdk> ChiTietPdks { get; set; }
    }
}
