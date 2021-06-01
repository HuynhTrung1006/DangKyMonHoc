using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_DangKyMonHoc.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_DangKyMonHoc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KhoaController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Khoa> getListKhoa()
        {
            var list = getListKhoa();
            return (IEnumerable<Khoa>)Ok(list);
        }
    }
}
