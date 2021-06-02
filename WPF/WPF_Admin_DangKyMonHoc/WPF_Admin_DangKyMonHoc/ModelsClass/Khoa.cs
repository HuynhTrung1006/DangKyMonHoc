using System;
using System.Collections.Generic;



namespace WPF_Admin_DangKyMonHoc.ModelsClass
{
    public partial class Khoa
    {
        public Khoa()
        {
            GiangViens = new HashSet<GiangVien>();
            SinhViens = new HashSet<SinhVien>();
        }

        public string MaKhoa { get; set; }
        public string TenKhoan { get; set; }

        public virtual ICollection<GiangVien> GiangViens { get; set; }
        public virtual ICollection<SinhVien> SinhViens { get; set; }
    }
}
