using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_DangKyMonHoc.Data.Interface;
using API_DangKyMonHoc.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_DangKyMonHoc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KhoaController : ControllerBase
    {
        private readonly IKhoaRepo _repo;

        public KhoaController(IKhoaRepo khoaRepo)
        {
            _repo = khoaRepo;
        }

        [HttpGet]
        public IActionResult getListKhoa()
        {
            var list = _repo.getListKhoa();
            return Ok(list);
        }

        [HttpGet("{id}")]
        public IActionResult getDetailKhoa(string id)
        {
            return Ok(_repo.getByElementID(id));
        }

        [HttpPost]
        public IActionResult postKhoa(Khoa kh)
        {
            bool check = _repo.postKhoa(kh);
            if (check == false) return NotFound();
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult delete(string id)
        {
            bool check = _repo.deleteKhoa(id);
            if (check == false) return NotFound();
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult putKhoa(Khoa k)
        {
            bool check = _repo.putKhoa(k);
            if (check == false) return NotFound();
            return Ok();
        }
    }
}
