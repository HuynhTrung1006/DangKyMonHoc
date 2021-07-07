using System;
using System.Collections.Generic;

#nullable disable

namespace API.Models
{
    public partial class HeDaoTao
    {
        public HeDaoTao()
        {
            ChuongTrinhDaoTaos = new HashSet<ChuongTrinhDaoTao>();
            Lops = new HashSet<Lop>();
        }

        public string MaDt { get; set; }
        public string TenDt { get; set; }

        public virtual ICollection<ChuongTrinhDaoTao> ChuongTrinhDaoTaos { get; set; }
        public virtual ICollection<Lop> Lops { get; set; }
    }
}
