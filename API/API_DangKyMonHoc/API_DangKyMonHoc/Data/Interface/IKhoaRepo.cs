using API_DangKyMonHoc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_DangKyMonHoc.Data.Interface
{
    public interface IKhoaRepo
    {
        IEnumerable<Khoa> getListKhoa();
        Khoa getByElementID(string id);
        bool postKhoa(Khoa k);
        bool deleteKhoa(string id);
        bool putKhoa(Khoa k);
    }
}
