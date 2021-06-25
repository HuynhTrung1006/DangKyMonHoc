using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class ThongTinMonHoc
    {
        public ThongTinMonHoc()
        {
            MonHocs = new HashSet<MonHoc>();
        }

        public string MaTtmh { get; set; }
        public int? PhantramGk { get; set; }
        public int? PhantramCk { get; set; }
        public int? PhantramQt { get; set; }
        public int? Sotiet { get; set; }

        public virtual ICollection<MonHoc> MonHocs { get; set; }
    }
}
