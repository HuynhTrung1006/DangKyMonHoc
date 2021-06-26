﻿using System;
using System.Collections.Generic;

#nullable disable

namespace API_DangKyMonHoc.Models
{
    public partial class HocKyDkmh
    {
        public HocKyDkmh()
        {
            CongDangKies = new HashSet<CongDangKy>();
        }

        public string MaHk { get; set; }
        public string TenHk { get; set; }

        public virtual ICollection<CongDangKy> CongDangKies { get; set; }
    }
}