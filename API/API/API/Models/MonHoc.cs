using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class MonHoc
    {
        public MonHoc()
        {
            ChiTietPdks = new HashSet<ChiTietPdk>();
            LopMonHocs = new HashSet<LopMonHoc>();
        }

        public string MaMh { get; set; }
        public string TenMh { get; set; }
        public byte Sotinchi { get; set; }
        public byte HesoHp { get; set; }
        public bool Thuchanh { get; set; }
        public string MonTq { get; set; }
        public string MaSh { get; set; }
        public string MaKhoi { get; set; }
        public string MaTtmh { get; set; }

        public virtual KhoiKienThuc MaKhoiNavigation { get; set; }
        public virtual ThongTinMonHoc MaTtmhNavigation { get; set; }
        public virtual ChiTietCtdt ChiTietCtdt { get; set; }
        public virtual MonHocDuocMo MonHocDuocMo { get; set; }
        public virtual ICollection<ChiTietPdk> ChiTietPdks { get; set; }
        public virtual ICollection<LopMonHoc> LopMonHocs { get; set; }
    }
}
