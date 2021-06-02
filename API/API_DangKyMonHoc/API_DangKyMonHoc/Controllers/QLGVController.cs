using API_DangKyMonHoc.Models;
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
	public class QLGVController : ControllerBase
	{
		private DangKyMonHocContext db = new DangKyMonHocContext();
		[HttpGet]
		public IEnumerable<GiangVien> getDSGv()
		{
			return db.GiangViens.ToList();
		}
		[HttpGet("{id}")]
		public async Task<ActionResult<GiangVien>> getGv(string id)
		{
			GiangVien a = await db.GiangViens.FindAsync(id);
			if (a == null)
				return NotFound();
			return Ok(a);

		}
		[HttpPost]
		public async Task<IActionResult> postGv(GiangVien a)
		{
			if (ModelState.IsValid)
			{
				//oUser.Password = BCrypt.Net.BCrypt.HashPassword(oUser.Password);
				//Global.Users.Add(oUser);
				//return oUser;
				

				db.GiangViens.Add(a);
				await db.SaveChangesAsync();
				return Ok();

			}
			return BadRequest();
		}
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteGiangVien(string id)
		{
			var Gv = await db.GiangViens.FindAsync(id);
			if (Gv == null)
				return NotFound();
			db.GiangViens.Remove(Gv);
			await db.SaveChangesAsync();
			return Ok();
		}
		[HttpPut]

		public async Task<IActionResult> PutGiangVien(GiangVien a)
		{
			GiangVien b = await db.GiangViens.FindAsync(a.MaGv);
			b.TenGv = a.TenGv;
			b.Email = a.Email;
			b.Chucvu = a.Chucvu;
			b.Sdt = a.Sdt;
			b.Ngaysinh = a.Ngaysinh;
			b.HocHam = a.HocHam;
			b.MaKhoa = a.MaKhoa;
			b.Phai = a.Phai;
			await db.SaveChangesAsync();
			return Ok();
		}
	}
}
