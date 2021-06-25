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
    public class NienkhoaController : ControllerBase
    {
        private Models.DangKyMonHocContext dc = new Models.DangKyMonHocContext();
        [HttpGet]
        public IActionResult getDSNienkhoa()
        {

            var list = dc.NienKhoas.ToList();

            return Ok(list);
        }
        [HttpPost]
        public IActionResult postDSNienkhoa(Models.NienKhoa n)
        {
            if (ModelState.IsValid == false) return BadRequest();
            Models.NienKhoa temp = dc.NienKhoas.Find(n.MaNk);
            if (temp != null) return BadRequest();
            Models.NienKhoa a = new Models.NienKhoa
            {
                MaNk = n.MaNk,
                TenNk = n.TenNk
             


            };
            dc.NienKhoas.Add(a);
            dc.SaveChanges();
            return Ok();

        }
        [HttpDelete("{id}")]
        public IActionResult deleteNienkhoa(string id)
        {
            Models.NienKhoa n = dc.NienKhoas.Find(id);
            if (n == null) return NotFound();
            foreach (var t in dc.NienKhoaCdks.Where(x => x.MaCdk == id))
            {
                return BadRequest();
            }
            dc.NienKhoas.Remove(n);
            dc.SaveChanges();
            return Ok();
        }
        [HttpPut]
        public IActionResult putNienkhoa(Models.NienKhoa n)
        {
            if (ModelState.IsValid == false) return BadRequest();
            Models.NienKhoa temp = dc.NienKhoas.Find(n.MaNk);
            if (temp == null) return NotFound();
          
            temp.TenNk = n.TenNk;
      


            dc.SaveChanges();
            return Ok();
        }
    }
}
