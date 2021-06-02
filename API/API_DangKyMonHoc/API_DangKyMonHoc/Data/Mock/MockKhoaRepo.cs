using API_DangKyMonHoc.Data.Interface;
using API_DangKyMonHoc.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_DangKyMonHoc.Data.Mock
{
    public class MockKhoaRepo : IKhoaRepo
    {
        private readonly DangKyMonHocContext _db;
        public MockKhoaRepo(DangKyMonHocContext dangKyMonHocContext)
        {
            _db = dangKyMonHocContext;
        }


        public bool deleteKhoa(string id)
        {
            var check =getByElementID(id);
            if (check == null) return false;
            _db.Khoas.Remove(check);
            _db.SaveChanges();
            return true;
        }

        public Khoa getByElementID(string id)
        {
            var check = _db.Khoas.Find(id.Trim());
            return check;
        }

        public IEnumerable<Khoa> getListKhoa()
        {
            return _db.Khoas.ToList();
        }

        public bool postKhoa(Khoa k)
        {
            var check = getByElementID(k.MaKhoa);
            if (check != null) return false;
            _db.Khoas.Add(k);
            _db.SaveChanges();
            return true;
        }

        public bool putKhoa(Khoa k)
        {
            var check = getByElementID(k.MaKhoa);
            if (check == null) return false;
           check.TenKhoan=k.TenKhoan;
            _db.SaveChanges();
            return true;
        }

       
    }
}
