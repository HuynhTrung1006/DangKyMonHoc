using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SinhvienController : ControllerBase
    {
        private Models.DangKyMonHocContext dc = new Models.DangKyMonHocContext();
        [HttpGet]
        public IActionResult getDSSinhvien()
        {

            var list = dc.SinhViens.ToList();

            return Ok(list);
        }
        [HttpPost]
        public IActionResult postDSSinhvien(Models.SinhVien s)
        {
            if (ModelState.IsValid == false) return BadRequest();
            Models.SinhVien temp = dc.SinhViens.Find(s.MaSv);
            if (temp != null) return BadRequest();
            Models.SinhVien a = new Models.SinhVien
            {
                MaSv = s.MaSv,
                TenSv = s.TenSv,
                Diachi = s.Diachi,
                Ngaysinh=s.Ngaysinh,
                Phai=s.Phai,
                Email=s.Email,
                Cnmd=s.Cnmd,
                Hinhanh=s.Hinhanh,
                Matkhau=s.Matkhau,
                MaLop=s.MaLop


            };
            dc.SinhViens.Add(a);
            dc.SaveChanges();
            return Ok();

        }
        [HttpDelete("{id}")]
        public IActionResult deleteSinhvien(string id)
        {
            Models.SinhVien n = dc.SinhViens.Find(id);
            if (n == null) return NotFound();
            foreach (var t in dc.Lops.Where(x => x.MaLop == id))
            {
                return BadRequest();
            }
            dc.SinhViens.Remove(n);
            dc.SaveChanges();
            return Ok();
        }
        [HttpPut]
        public IActionResult putSinhvien(Models.SinhVien s)
        {
            if (ModelState.IsValid == false) return BadRequest();
            Models.SinhVien temp = dc.SinhViens.Find(s.MaSv);
            if (temp == null) return NotFound();

                temp.TenSv = s.TenSv;
                temp.Diachi = s.Diachi;
                temp.Ngaysinh = s.Ngaysinh;
                temp.Phai = s.Phai;
                temp.Email = s.Email;
                temp.Cnmd = s.Cnmd;
                temp.Hinhanh = s.Hinhanh;
                temp.Matkhau = s.Matkhau;
                temp.MaLop = s.MaLop;


            dc.SaveChanges();
            return Ok();
        }
    }
}
