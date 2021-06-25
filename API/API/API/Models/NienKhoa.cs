using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class NienKhoa
    {
        public NienKhoa()
        {
            Lops = new HashSet<Lop>();
        }

        public string MaNk { get; set; }
        public string TenNk { get; set; }

        public virtual NienKhoaCdk NienKhoaCdk { get; set; }
        public virtual ICollection<Lop> Lops { get; set; }
    }
}
