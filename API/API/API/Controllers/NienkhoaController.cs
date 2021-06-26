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
    public class NienkhoaController : ControllerBase
    {
		private DangKyMonHocContext db = new DangKyMonHocContext();
		[HttpGet]
		public IEnumerable<NienKhoa> getAll()
		{
			return db.NienKhoas.ToList();
		}
		[HttpGet("{id}")]
		public async Task<ActionResult<NienKhoa>> getNienkhoa(string id)
		{

			NienKhoa a = await db.NienKhoas.FindAsync(id);
			if (a != null)
				return Ok(a);
			else
				return NotFound();


		}
		[HttpPost]
		public async Task<IActionResult> postNienkhoa(NienKhoa nk)
		{
			if (ModelState.IsValid)
			{
				db.NienKhoas.Add(nk);
				await db.SaveChangesAsync();
				return Ok();
			}
			return BadRequest();
		}
		[HttpDelete("{id}")]
		public async Task<IActionResult> deleteNienkhoa(string id)
		{
			var lop = db.Lops.SingleOrDefault(x => x.MaNk == id);
			
			if (lop !=null)
				return BadRequest();
			NienKhoa a = await db.NienKhoas.FindAsync(id);
			if (a == null)
			{
				return NotFound();
			}
			db.NienKhoas.Remove(a);
			await db.SaveChangesAsync();
			return Ok();
		}
		[HttpPut]
		public async Task<IActionResult> PutNienkhoa(NienKhoa nienkhoa)
		{
			NienKhoa nk = await db.NienKhoas.FindAsync(nienkhoa.MaNk);
			if (nk == null)
				return NotFound();
		
			nk.TenNk = nienkhoa.TenNk;
			
			await db.SaveChangesAsync();
			return Ok();


		}
	}
}
