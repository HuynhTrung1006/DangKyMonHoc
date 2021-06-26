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
		private DangKyMonHocContext db = new DangKyMonHocContext();
		[HttpGet]
		public IEnumerable<Lop> getAll()
		{
			return db.Lops.ToList();
		}
		[HttpGet("{id}")]
		public async Task<ActionResult<Lop>> getlop(string id)
		{

			Lop a = await db.Lops.FindAsync(id);
			if (a != null)
				return Ok(a);
			else
				return NotFound();


		}
		[HttpPost]
		public async Task<IActionResult> postlop(Lop lop)
		{
			if (ModelState.IsValid)
			{
				db.Lops.Add(lop);
				await db.SaveChangesAsync();
				return Ok();
			}
			return BadRequest();
		}
		[HttpDelete("{id}")]
		public async Task<IActionResult> deletelop(string id)
		{
			var sinhvien = db.SinhViens.SingleOrDefault(x => x.MaLop == id);
			if (sinhvien != null)
				return BadRequest();
			Lop a = await db.Lops.FindAsync(id);
			if (a == null)
			{
				return NotFound();
			}
			db.Lops.Remove(a);
			await db.SaveChangesAsync();
			return Ok();
		}
		[HttpPut]
		public async Task<IActionResult> Putlop(Lop lop)
		{
			Lop l = await db.Lops.FindAsync(lop);
			if (l == null)
				return NotFound();
			l.TenLop = lop.TenLop;
			l.Siso = lop.Siso;
			l.MaNganh = lop.MaNganh;
			l.MaNk = lop.MaNk;
			await db.SaveChangesAsync();
			return Ok();


		}

	}
}

