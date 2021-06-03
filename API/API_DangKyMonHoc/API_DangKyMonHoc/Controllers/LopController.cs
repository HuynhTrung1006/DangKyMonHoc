using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_DangKyMonHoc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LopController : ControllerBase
    {
        private Models.DangKyMonHocContext dc = new Models.DangKyMonHocContext();
        [HttpGet]
        public IActionResult getDSLop()
        {

            var list = dc.Lops.ToList();

            return Ok(list);
        }
        [HttpPost]
        public IActionResult postDSLop(Models.Lop l)
        {
            if (ModelState.IsValid == false) return BadRequest();
            Models.Lop temp = dc.Lops.Find(l.MaLop);
            if (temp != null) return BadRequest();
            Models.Lop a = new Models.Lop
            {
                MaLop = l.MaLop,
                TenLop = l.TenLop,
                SiSo=l.SiSo,
                NienKhoa=l.NienKhoa,

            };
            dc.Lops.Add(a);
            dc.SaveChanges();
            return Ok();

        }
        [HttpDelete("{id}")]
        public IActionResult deleteLop(string id)
        {
            Models.Lop l = dc.Lops.Find(id);

            dc.Lops.Remove(l);
            dc.SaveChanges();
            return Ok();
        }
        [HttpPut]
        public IActionResult putLop(Models.Lop l)
        {
            if (ModelState.IsValid == false) return BadRequest();
            Models.Lop temp = dc.Lops.Find(l.MaLop);
            if (temp == null) return NotFound();
            temp.MaLop = l.MaLop;
            temp.TenLop = l.TenLop;
            temp.SiSo = l.SiSo;
            temp.NienKhoa = l.NienKhoa;


            dc.SaveChanges();
            return Ok();
        }

    }
}
