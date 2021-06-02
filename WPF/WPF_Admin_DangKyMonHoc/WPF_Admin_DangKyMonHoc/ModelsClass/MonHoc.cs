using System;
using System.Collections.Generic;



namespace WPF_Admin_DangKyMonHoc.ModelsClass
{
    public partial class MonHoc
    {
        public string MaMh { get; set; }
        public string TenMh { get; set; }
        public byte Sotc { get; set; }
        public byte HeSoHp { get; set; }
        public bool ThucHanh { get; set; }
        public string MaKhoi { get; set; }

        public virtual KhoiKienThuc MaKhoiNavigation { get; set; }
    }
}
