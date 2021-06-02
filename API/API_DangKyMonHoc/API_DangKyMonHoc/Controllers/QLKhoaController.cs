using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_DangKyMonHoc.Models;
namespace API_DangKyMonHoc.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class QLKhoaController : ControllerBase
	{
		private DangKyMonHocContext db = new DangKyMonHocContext();
		[HttpGet]
		public IEnumerable<Khoa> getAll()
		{
			return db.Khoas.ToList();
		}
	}
}
