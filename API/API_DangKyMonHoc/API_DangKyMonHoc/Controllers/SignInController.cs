
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
	public class SignInController : ControllerBase
	{
		private DangKyMonHocContext db = new DangKyMonHocContext();
		[HttpPost]
		public ActionResult PostSignIn(NhanVien a)
		{
			NhanVien b =  db.NhanViens.SingleOrDefault(x => x.MaNv == a.MaNv);
			bool isValidPassword = BCrypt.Net.BCrypt.Verify(a.MatKhau, b.MatKhau);
			if (isValidPassword == true)
				return Ok();
			else
				return BadRequest();

		}
	}
}
