using API_DangKyMonHoc.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_DangKyMonHoc.Data
{
    public class MockQLSVRepo : IQLSVRepo
    {
        private  DangKyMonHocContext _db = new DangKyMonHocContext();

        public bool deleteSinhVien(string id)
        {
            SinhVien sv = getElementById(id);
            if(sv==null)
            {
                return false;
            }
            _db.SinhViens.Remove(sv);
            _db.SaveChanges();
            return true;
        }

        public bool editSinhVien(SinhVien sv)
        {
            SinhVien checkSV = getElementById(sv.MsSv);
            if(checkSV==null)
            {
                return false;
            }
            _db.Remove(checkSV);
            _db.Add(sv);
            _db.SaveChanges();
            return true;
        }

        public SinhVien getElementById(string id)
        {
            var checkSV =  _db.SinhViens.Find(id) as SinhVien;

            return checkSV;
        }

        //public MockQLSVRepo(DangKyMonHocContext dangKyMonHocContext)
        //{
        //    _db = dangKyMonHocContext;
        //}
        public IEnumerable<SinhVien> getSinhVien()
        {
            var list = _db.SinhViens.AsNoTracking().ToList();
            return (IEnumerable<SinhVien>)list;
        }

        public void postSinhVien(SinhVien sv)
        {
             _db.SinhViens.Add(sv);
            _db.SaveChanges();
        }

        
    }
}
