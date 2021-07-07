using API.Models;
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

            Nganh manganh = dc.Nganhs.Where(x => x.MaNganh.Contains(l.MaNganh)).FirstOrDefault();
            var makhoa = dc.Khoas.Where(x => x.MaKhoa.Contains(manganh.MaKhoa)).FirstOrDefault();
            string ma_hedaotao = l.MaDt.Substring(0, 1);


            l.MaLop = ma_hedaotao + l.MaNk.Trim() + "_" + makhoa.TenVietTat.Trim() + l.MaLop.Trim();
            dc.Lops.Add(l);
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
        [HttpPut("{id}")]
        public IActionResult putLop(Models.Lop l)
        {
            if (ModelState.IsValid == false) return BadRequest();
            Models.Lop temp = dc.Lops.Find(l.MaLop);
            if (temp == null) return NotFound();
            
            temp.Siso = l.Siso;
           


            dc.SaveChanges();
            return Ok();
        }

    }
}

