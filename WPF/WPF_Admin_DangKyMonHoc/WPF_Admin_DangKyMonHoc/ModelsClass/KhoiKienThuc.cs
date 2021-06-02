using System;
using System.Collections.Generic;



namespace WPF_Admin_DangKyMonHoc.ModelsClass
{
    public partial class KhoiKienThuc
    {
        public KhoiKienThuc()
        {
            MonHocs = new HashSet<MonHoc>();
        }

        public string MaKhoi { get; set; }
        public string TenKhoi { get; set; }
        public string TenChuyenMon { get; set; }
        public bool? BatBuoc { get; set; }

        public virtual ICollection<MonHoc> MonHocs { get; set; }
    }
}
