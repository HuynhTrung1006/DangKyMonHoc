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
                Siso=l.Siso,
                MaNganh=l.MaNganh,
                MaNk=l.MaNk
                

            };
            dc.Lops.Add(a);
            dc.SaveChanges();
            return Ok();

        }
        [HttpDelete("{id}")]
        public IActionResult deleteLop(string id)
        {
            Models.Lop l = dc.Lops.Find(id);
            if (l == null) return NotFound();
            foreach (var t in dc.SinhViens.Where(x => x.MaLop == id))
            {
                return BadRequest();
            }
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
            temp.Siso = l.Siso;
            temp.MaNganh = l.MaNganh;
            temp.MaNk = l.MaNk;


            dc.SaveChanges();
            return Ok();
        }

    }
}

