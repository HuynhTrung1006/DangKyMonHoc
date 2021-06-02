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
	public class QLNVController : ControllerBase
	{
		private DangKyMonHocContext db = new DangKyMonHocContext();
		[HttpGet]
		public IEnumerable<NhanVien> getDSNV()
		{
			return db.NhanViens.ToList(); 
		}
		[HttpGet("{id}")]
		public async Task<ActionResult<NhanVien>> getNV(string id)
		{
			NhanVien a = await db.NhanViens.FindAsync(id);
			if (a == null)
				return NotFound();
			return Ok(a);

		}
		[HttpPost]
		public async Task<IActionResult> postNV(NhanVien a)
		{
			if(ModelState.IsValid)
			{
				//oUser.Password = BCrypt.Net.BCrypt.HashPassword(oUser.Password);
				//Global.Users.Add(oUser);
				//return oUser;
				a.MatKhau = BCrypt.Net.BCrypt.HashPassword(a.MatKhau);

				db.NhanViens.Add(a);
					await db.SaveChangesAsync();
					return Ok();
				
			}
			return BadRequest();
		}
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteNhanVien(string id)
		{
			var nv = await db.NhanViens.FindAsync(id);
			if (nv == null)
				return NotFound();
			db.NhanViens.Remove(nv);
			await db.SaveChangesAsync();
			return Ok();
		}
		[HttpPut]

		public async Task<IActionResult> PutNhanVien(NhanVien a)
		{
			NhanVien b =  await db.NhanViens.FindAsync(a.MaNv);
			b.TenNv = a.TenNv;
			b.EmailNv = a.EmailNv;
			b.Chucvu = a.Chucvu;
			b.SdtNv = a.SdtNv;
			b.NgaysinhNv = a.NgaysinhNv;
			b.Trangthai = a.Trangthai;
			a.MatKhau = b.MatKhau;
			 await db.SaveChangesAsync();
			return Ok();
		}
		 
	}

}
