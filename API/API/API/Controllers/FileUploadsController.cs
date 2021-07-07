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
        public FileUploadsController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpPost]
        public string post([FromForm]FileUpload objectFile)
        {
            try
            {
                if (objectFile.files.Length>0)
                {
                    //string path = _webHostEnvironment.WebRootPath + "\\uploads\\";
                    string path = Environment.CurrentDirectory + "\\uploads\\"+objectFile.name+"\\"; //API/bin/debug/IMG/?
                    //path = AppDomain.CurrentDomain.BaseDirectory;
                    //path = AppDomain.CurrentDomain.BaseDirectory + @"IMG\";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    using (FileStream fileStream= System.IO.File.Create(path + objectFile.files.FileName))
                    {
                        objectFile.files.CopyTo(fileStream);
                        fileStream.Flush();
                        return "Uploaded";
                    }
                }
                else
                {
                    return "Not Uploaded";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
                //throw;
            }
        }

        [HttpDelete]
        public string Delete([FromForm] FileUpload objectFile)
        {
            try
            {
                if (objectFile.files.Length > 0)
                {
                    //string path = _webHostEnvironment.WebRootPath + "\\uploads\\";
                    string path = Environment.CurrentDirectory + "\\uploads\\" + objectFile.name + "\\"+objectFile.files.FileName; //API/bin/debug/IMG/?
                    //path = AppDomain.CurrentDomain.BaseDirectory;
                    //path = AppDomain.CurrentDomain.BaseDirectory + @"IMG\";
                    //if (!Directory.Exists(path))
                    //{
                    //    Directory.CreateDirectory(path);
                    //}
                    //using (FileStream fileStream = System.IO.File.Delete(path.))
                    //{
                    //    objectFile.files.CopyTo(fileStream);
                    //    fileStream.Flush();
                    //    return "Uploaded";
                    //}
                    System.IO.File.Delete(path);
                    return "Success";
                }
                else
                {
                    return "Not Uploaded";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
                //throw;
            }
        }

        
    }
}
