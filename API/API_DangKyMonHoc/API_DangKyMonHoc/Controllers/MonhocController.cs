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
    public class MonHocController : ControllerBase
    {
        private Models.DangKyMonHocContext dc = new Models.DangKyMonHocContext();
        [HttpGet]
        public IActionResult getDSMonHoc()
        {

            var list = dc.MonHocs.ToList();

            return Ok(list);
        }
        [HttpPost]
        public IActionResult postDSMonHoc(Models.MonHoc mh)
        {
            if (ModelState.IsValid == false) return BadRequest();
            Models.MonHoc temp = dc.MonHocs.Find(mh.MaMh);
            if (temp != null) return BadRequest();
            Models.MonHoc a = new Models.MonHoc
            {
                MaMh = mh.MaMh,
                TenMh = mh.TenMh,
                Sotc = mh.Sotc,
                HeSoHp = mh.HeSoHp,
                ThucHanh=mh.ThucHanh,
                MaKhoi=mh.MaKhoi,
              




            };
            dc.MonHocs.Add(a);
            dc.SaveChanges();
            return Ok();

        }
        [HttpDelete("{id}")]
        public IActionResult deleteMonHoc(string id)
        {
            Models.MonHoc mh = dc.MonHocs.Find(id);

            dc.MonHocs.Remove(mh);
            dc.SaveChanges();
            return Ok();
        }
        [HttpPut]
        public IActionResult putMonHoc(Models.MonHoc mh)
        {
            if (ModelState.IsValid == false) return BadRequest();
            Models.MonHoc temp = dc.MonHocs.Find(mh.MaMh);
            if (temp == null) return NotFound();
            temp.MaMh = mh.MaMh;
            temp.TenMh = mh.TenMh;
            temp.Sotc = mh.Sotc;
            temp.HeSoHp = mh.HeSoHp;
            temp.ThucHanh = mh.ThucHanh;
            temp.MaKhoi = mh.MaKhoi;

            dc.SaveChanges();
            return Ok();
        }

    }
}
