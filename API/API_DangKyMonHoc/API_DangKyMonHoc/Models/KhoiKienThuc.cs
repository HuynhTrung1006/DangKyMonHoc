﻿using System;
using System.Collections.Generic;

#nullable disable

namespace API_DangKyMonHoc.Models
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