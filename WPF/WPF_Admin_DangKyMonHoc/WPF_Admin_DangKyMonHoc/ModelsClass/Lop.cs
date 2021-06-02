using System;
using System.Collections.Generic;


namespace WPF_Admin_DangKyMonHoc.ModelsClass
{
    public partial class Lop
    {
        public Lop()
        {
            SinhViens = new HashSet<SinhVien>();
        }

        public string MaLop { get; set; }
        public string TenLop { get; set; }
        public byte? SiSo { get; set; }
        public string NienKhoa { get; set; }

        public virtual ICollection<SinhVien> SinhViens { get; set; }
    }
}
