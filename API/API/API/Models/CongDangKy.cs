using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class CongDangKy
    {
        public CongDangKy()
        {
            LopMonHocs = new HashSet<LopMonHoc>();
        }

        public string MaCdk { get; set; }
        public string TenCdk { get; set; }
        public DateTime? ThoigianBatDau { get; set; }
        public DateTime? ThoigianKetThuc { get; set; }
        public bool Trangthai { get; set; }
        public string MaHk { get; set; }
        public string MaNh { get; set; }

        public virtual HocKyDkmh MaHkNavigation { get; set; }
        public virtual NamHocDkmh MaNhNavigation { get; set; }
        public virtual MonHocDuocMo MonHocDuocMo { get; set; }
        public virtual NienKhoaCdk NienKhoaCdk { get; set; }
        public virtual ICollection<LopMonHoc> LopMonHocs { get; set; }
    }
}
