using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_DangKyMonHoc.Data;
using API_DangKyMonHoc.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_DangKyMonHoc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QLSVController : ControllerBase
    {
        //private readonly DangKyMonHocContext _db;
        private readonly IQLSVRepo _repository;

        //public QLSVController(DangKyMonHocContext dangKyMonHocContext)
        //{
        //    _db = dangKyMonHocContext;
        //}
        public QLSVController(IQLSVRepo qLSVRepo)
        {
            _repository = qLSVRepo;
        }

        [HttpGet]
        public IEnumerable<SinhVien> getSinhVien()
        {
            var list = _repository.getSinhVien();

            return list;
        }

        [HttpGet("{id}")]
        public IActionResult getDetailSinhVien(string id)
        {
            var check = _repository.getElementById(id);
            if(check==null)
            {
                return NotFound();
            }
            return Ok(check);
        }

        [HttpPost]
        public IActionResult postSinhVien(SinhVien sv)
        {
            if (ModelState.IsValid)
            {
                var checkSinhVien = _repository.getElementById(sv.MsSv);
                if (checkSinhVien != null) return NotFound();

                sv.Matkhau = BCrypt.Net.BCrypt.HashPassword(sv.Matkhau + sv.MsSv);
                _repository.postSinhVien(sv);
                return Ok();
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult deleteSinhVien(string id)
        {
            var isCheckDelete = _repository.deleteSinhVien(id);
            if(isCheckDelete==false)
            {
                return NotFound();
            }
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult putSinhVien(SinhVien sv)
        {
            if (ModelState.IsValid)
            {
                bool isEditSV=_repository.editSinhVien(sv);
                if(isEditSV==false)
                {
                    return BadRequest();
                }
                return Ok();
            }

            return NotFound();
        }
    }
}
