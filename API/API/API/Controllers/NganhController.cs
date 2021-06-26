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
    public class NganhController : ControllerBase
    {
        private Models.DangKyMonHocContext db = new Models.DangKyMonHocContext();
        [HttpGet]
		
		public IEnumerable<Nganh> getAll()
		{
			return db.Nganhs.ToList();
		}
		[HttpGet("{id}")]
		public async Task<ActionResult<Nganh>> getNganh(string id)
		{

			Nganh a = await db.Nganhs.FindAsync(id);
			if (a != null)
				return Ok(a);
			else
				return NotFound();


		}
		[HttpPost]
		public async Task<IActionResult> postNganh(Nganh nganh)
		{
			if (ModelState.IsValid)
			{
				db.Nganhs.Add(nganh);
				await db.SaveChangesAsync();
				return Ok();
			}
			return BadRequest();
		}
		[HttpDelete("{id}")]
		public async Task<IActionResult> deleteNganh(string id)
		{
			var chuongtrinhdaotao = db.ChuongTrinhDaoTaos.FirstOrDefault(x => x.MaNganh == id);
			var lop = db.Lops.FirstOrDefault(x => x.MaNganh == id);
			if (chuongtrinhdaotao != null || lop != null)
				return BadRequest();
			Nganh a = await db.Nganhs.FindAsync(id);
			if (a == null)
			{
				return NotFound();
			}
			db.Nganhs.Remove(a);
			await db.SaveChangesAsync();
			return Ok();
		}
		[HttpPut]
		public async Task<IActionResult> PutNganh(Nganh nganh)
		{
			Nganh n = await db.Nganhs.FindAsync(nganh.MaNganh);
			if (n == null)
				return NotFound();
		
			n.TenNganh = nganh.TenNganh;
			n.MaKhoa = nganh.MaKhoa;
			await db.SaveChangesAsync();
			return Ok();


		}

	}
}

