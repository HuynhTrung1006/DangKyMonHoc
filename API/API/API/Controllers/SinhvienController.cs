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
    public class SinhvienController : ControllerBase
    {
		DangKyMonHocContext db = new DangKyMonHocContext();
		[HttpGet]
		public IEnumerable<SinhVien> getDSSv()
		{
			return db.SinhViens.ToList();
		}
		[HttpGet("{id}")]
		public async Task<ActionResult<SinhVien>> getSv(string id)
		{
			SinhVien a = await db.SinhViens.FindAsync(id);
			if (a == null)
				return NotFound();
			return Ok(a);

		}
		[HttpPost]
		public async Task<IActionResult> postSv(SinhVien a)
		{
			if (ModelState.IsValid)
			{
				var lop = db.Lops.FirstOrDefault(x => x.MaLop == a.MaLop);
				var nganh = db.Nganhs.FirstOrDefault(x => x.MaNganh == lop.MaNganh);
				var ctdt = db.ChuongTrinhDaoTaos.FirstOrDefault(x => x.MaNganh == nganh.MaNganh);
			
				var nienkhoa = db.NienKhoas.FirstOrDefault(x => x.MaNk == lop.MaNk);
				a.MaSv = ctdt.MaDt.Trim() + nganh.MaKhoa.Trim() +nienkhoa.MaNk.Trim() + a.MaSv.Trim();
				

				db.SinhViens.Add(a);
				await db.SaveChangesAsync();
				return Ok();

			}
			return BadRequest();
		}
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteSinhvien(string id)
		{

			var phieudangky= db.PhieuDangKies.FirstOrDefault(x => x.MaSv == id);
			var phucKhao = db.PhucKhaos.FirstOrDefault(x => x.MaSv == id);
			if (phieudangky != null || phucKhao != null)
				return BadRequest();
			SinhVien a = await db.SinhViens.FindAsync(id);
			if (a == null)
			{
				return NotFound();
			}
			db.SinhViens.Remove(a);
			await db.SaveChangesAsync();
			return Ok();
		}
		[HttpPut]

		public async Task<IActionResult> PutSinhvien(SinhVien a)
		{
			SinhVien b = await db.SinhViens.FindAsync(a.MaSv);
			if (b == null)
				return BadRequest();
			b.TenSv = a.TenSv;
			b.Email = a.Email;
			b.Cnmd = a.Cnmd;
			b.Diachi = a.Diachi;
			b.Ngaysinh = a.Ngaysinh;
			b.Phai = a.Phai;
			b.Matkhau = a.Matkhau;
			b.Hinhanh = a.Hinhanh;
			b.MaLop = a.MaLop;
			await db.SaveChangesAsync();
			return Ok();
		}
	}
}
