using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileUploadsController : ControllerBase
    {
        public static IWebHostEnvironment _webHostEnvironment;
        private readonly DangKyMonHocContext _db = new DangKyMonHocContext();
        public FileUploadsController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        //string path = Environment.CurrentDirectory + "\\uploads\\" + objectFile.name + "\\"; //API/bin/debug/IMG/?
        [HttpGet("{id}")]
        public IActionResult gethinh(string id)
        {
            NhanVien nv = _db.NhanViens.Find(id);
            if (nv != null)
            {
                if (nv.Hinhanh == "") return NotFound();
                string path = Environment.CurrentDirectory + "\\uploads\\NhanVien\\"+nv.Hinhanh;
                if (System.IO.File.Exists(path) == false) return BadRequest();
                System.IO.FileStream f = new FileStream(path, FileMode.Open, FileAccess.Read);
                byte[] buf = new byte[f.Length];
                f.Read(buf, 0, (int)f.Length);
                f.Close();
                return Ok(buf);
            }
            GiangVien gv = _db.GiangViens.Find(id);
            if (gv != null)
            {
                if (gv.Hinhanh == "") return NotFound();
                string path = Environment.CurrentDirectory + "\\uploads\\GiangVien\\" + gv.Hinhanh;
                if (System.IO.File.Exists(path) == false) return BadRequest();
                System.IO.FileStream f = new FileStream(path, FileMode.Open, FileAccess.Read);
                byte[] buf = new byte[f.Length];
                f.Read(buf, 0, (int)f.Length);
                f.Close();
                return Ok(buf);
            }
            SinhVien sv = _db.SinhViens.Find(id);
            if (sv != null)
            {
                if (sv.Hinhanh == "") return NotFound();
                string path = Environment.CurrentDirectory + "\\uploads\\SinhVien\\" + sv.Hinhanh;
                if (System.IO.File.Exists(path) == false) return BadRequest();
                System.IO.FileStream f = new FileStream(path, FileMode.Open, FileAccess.Read);
                byte[] buf = new byte[f.Length];
                f.Read(buf, 0, (int)f.Length);
                f.Close();
                return Ok(buf);
            }
            return NotFound();
        }
        [HttpPost]
        public IActionResult posthinh(FileUpload x)
        {
            
                string path = Environment.CurrentDirectory + "\\uploads\\" + x.name + "\\" + x.tenhinh;
                System.IO.FileStream f = new FileStream(path, FileMode.Create, FileAccess.Write);
                f.Write(x.hinh, 0, (int)x.hinh.Length);
                f.Close();
                return Ok();
           
        }

        [HttpDelete("{id}")]
        public IActionResult deleteHinh(string id)
        {
            NhanVien nv = _db.NhanViens.Find(id);
            if (nv != null)
            {
                if (nv.Hinhanh == "") return NotFound();
                string path = Environment.CurrentDirectory + "\\uploads\\NhanVien\\" + nv.Hinhanh;
                if (System.IO.File.Exists(path) == false) return BadRequest();
                System.IO.File.Delete(path);
                return Ok();
            }
            GiangVien gv = _db.GiangViens.Find(id);
            if (gv != null)
            {
                if (gv.Hinhanh == "") return NotFound();
                string path = Environment.CurrentDirectory + "\\uploads\\GiangVien\\" + gv.Hinhanh;
                if (System.IO.File.Exists(path) == false) return BadRequest();
                System.IO.File.Delete(path);
                return Ok();
            }
            SinhVien sv = _db.SinhViens.Find(id);
            if (sv != null)
            {
                if (sv.Hinhanh == "") return NotFound();
                string path = Environment.CurrentDirectory + "\\uploads\\SinhVien\\" + sv.Hinhanh;
                if (System.IO.File.Exists(path) == false) return BadRequest();
                System.IO.File.Delete(path);
                return Ok();
            }
            return NotFound();
        }
    }
}
