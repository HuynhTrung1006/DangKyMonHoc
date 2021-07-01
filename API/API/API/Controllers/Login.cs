using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Login : ControllerBase
    {
        private DangKyMonHocContext db = new DangKyMonHocContext();
        [HttpPost]
        public ActionResult PostSignIn(GiangVien a)
        {
            GiangVien b = db.GiangViens.SingleOrDefault(x => x.MaGv == a.MaGv);
            bool isValidPassword = BCrypt.Net.BCrypt.Verify(a.Matkhau, b.Matkhau);
            if (isValidPassword == true)
            {
                if (b.Trangthai == true) return Ok();
                return BadRequest();
            }
            else
                return BadRequest();

        }

        [HttpPost]
        public ActionResult PostSignIn(NhanVien a)
        {
            NhanVien b = db.NhanViens.SingleOrDefault(x => x.MaNv == a.MaNv);
            bool isValidPassword = BCrypt.Net.BCrypt.Verify(a.Matkhau, b.Matkhau.Trim());
            if (isValidPassword == true)
            {
                if (b.Trangthai == true) return Ok();
                return BadRequest();
            }    
            else
                return BadRequest();

        }

        [HttpPost]
        public ActionResult PostSignIn(SinhVien a)
        {
            SinhVien b = db.SinhViens.SingleOrDefault(x => x.MaSv == a.MaSv);
            bool isValidPassword = BCrypt.Net.BCrypt.Verify(a.Matkhau, b.Matkhau.Trim());
            if (isValidPassword == true)
            {
                if (b.Trangthai == true) return Ok();
                return BadRequest();
            }
            else
                return BadRequest();

        }


        
    }
}
