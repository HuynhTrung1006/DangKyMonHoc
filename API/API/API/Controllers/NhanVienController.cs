using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using API.Models;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NhanVienController : ControllerBase
    {
		private DangKyMonHocContext _db = new DangKyMonHocContext();

		[HttpGet]
		public IEnumerable<NhanVien> GetDSNV()
		{
			return _db.NhanViens.ToList();
		}
		[HttpGet("{id}")]
		public async Task<ActionResult<NhanVien>> GetNhanVien(string id)
		{
			var a = await _db.NhanViens.FindAsync(id);
			if (a == null)
				return NotFound();
			else
				return Ok(a);

		}
		//Hash password
		public string encode(string password)
		{
			// generate a 128-bit salt using a secure PRNG
			byte[] salt = new byte[128 / 8];
			//using (var rng = RandomNumberGenerator.Create())
			//{
			//	rng.GetBytes(salt);
			//}
			

			// derive a 256-bit subkey (use HMACSHA1 with 10,000 iterations)
			string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
				password: password,
				salt: salt,
				prf: KeyDerivationPrf.HMACSHA1,
				iterationCount: 10000,
				numBytesRequested: 256 / 8));
			return hashed;
		}

		[HttpPost]
		public async Task<ActionResult<NhanVien>> PostNhanvien(NhanVien a)
		{
			a.MaNv = a.MaChucVu.Trim() + a.MaNv.Trim();

			var checkNV=await _db.NhanViens.FindAsync(a.MaNv.Trim());
			if (checkNV != null) return NotFound();

			//Xu ly du lieu: 
			 // cau truc NV001 (nv: ma chuc vu)
			a.Matkhau = encode(a.Matkhau);//encode pass

			_db.NhanViens.Add(a);
			await _db.SaveChangesAsync();
			return Ok();
		}
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteNhanvien(string id)
		{
			var checkNV = await _db.NhanViens.FindAsync(id.Trim());
			if (checkNV == null) return NotFound();
			_db.NhanViens.Remove(checkNV);
			await _db.SaveChangesAsync();
			return Ok();
		}

		//ERROR
		[HttpPut("{id}")]
		public async Task<IActionResult> PutNhanVien(NhanVien a)
		{
			var nv = await _db.NhanViens.FindAsync(a.MaNv);
			if (nv == null)
				return NotFound();

			a.Matkhau = encode(a.Matkhau);
			_db.NhanViens.Update(a);
			await _db.SaveChangesAsync();
			return Ok();

		}

	}
}
