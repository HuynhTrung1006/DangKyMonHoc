using API.Models;
using BCrypt.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.XuLy
{
    public class Input_Ma
    {
        private readonly DangKyMonHocContext db = new DangKyMonHocContext();
        //xu ly ma sinh vien
        public string maSinhVien(string masv, string malop)
        {
            var lop = db.Lops.FirstOrDefault(x => x.MaLop == malop);
            var nganh = db.Nganhs.FirstOrDefault(x => x.MaNganh == lop.MaNganh);
            var ctdt = db.ChuongTrinhDaoTaos.FirstOrDefault(x => x.MaNganh == nganh.MaNganh);

            var nienkhoa = db.NienKhoas.FirstOrDefault(x => x.MaNk == lop.MaNk);
            masv = ctdt.MaDt.Trim() + nganh.MaKhoa.Trim() + nienkhoa.MaNk.Trim() + masv.Trim();

            return masv;
        }

        public string hashPassword(string pass)
        {
            string hash = BCrypt.Net.BCrypt.HashPassword(pass);
            return hash;
        }
    }
}
