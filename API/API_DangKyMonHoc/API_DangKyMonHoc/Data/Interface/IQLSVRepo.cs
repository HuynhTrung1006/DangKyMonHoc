using API_DangKyMonHoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_DangKyMonHoc.Data
{
    public interface IQLSVRepo
    {
        IEnumerable<SinhVien> getSinhVien();
        SinhVien getElementById(string id);
        void postSinhVien(SinhVien sv);
        bool deleteSinhVien(string id);
        bool editSinhVien(SinhVien sv);
    }
}
