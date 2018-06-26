using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SaleService.Models;

namespace SaleService.Controllers
{   
    [Route("api/files")]
    //[Consumes("application/json", "multipart/form-data")]
    [Produces("application/json")]
    public class FileController : Controller
    {
        private readonly IHostingEnvironment _hostingEnvironment;

        public FileController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }


        [HttpPost]
        public ResultObject UploadAjax()
        {
            Console.WriteLine("Uploading...");

            var files = Request.Form.Files;

            List<String> filenames = new List<string>();

            foreach (var file in files)
            {
                var fileName = file.FileName;
                Console.WriteLine(fileName);

                fileName = _hostingEnvironment.WebRootPath + $"/UploadFile/{fileName}";
                filenames.Add(fileName);

                using (FileStream fs = System.IO.File.Create(fileName))
                {
                    file.CopyTo(fs);
                    fs.Flush();
                }
            }

            return new ResultObject
            {
                state = "Success",
                resultObject = filenames
            };
        }

        [HttpPost("form")]
        public ResultObject UploadForm(IFormCollection form)
        {
            Console.WriteLine("IFormCollection Uploading...");
            List<String> filenames = new List<string>();                    

            var files = form.Files;

            foreach (var file in files.ToList())
            {
                var fileName = file.FileName;
                Console.WriteLine(fileName);

                fileName = $"/UploadFile/{fileName}";
                filenames.Add(fileName);

                fileName = _hostingEnvironment.WebRootPath + fileName;

                using (FileStream fs = System.IO.File.Create(fileName))
                {
                    file.CopyTo(fs);
                    fs.Flush();
                }
            }

            return new ResultObject
            {
                state = "Success",
                resultObject = filenames
            };
        }

        [HttpPost("iform")]
        public ResultObject UploadIForm(List<IFormFile> files,String Code)
        {
            Console.WriteLine("IFormFile List Uploading...");
            Console.WriteLine("Code="+ Code);
            List<String> filenames = new List<string>();

            HttpRequest request = Request;
            Console.WriteLine("request.ContentType = " + request.ContentType);

            if (files==null)
            {
                Console.WriteLine("files==null");

                return new ResultObject
                {
                    state = "Fail",
                    resultObject = "files==null"
                };
            }

            Console.WriteLine("files.Count=" + files.Count);

            foreach (var file in files)
            {
                var fileName = file.FileName;
                Console.WriteLine(fileName);

                fileName = $"/UploadFile/{fileName}";
                filenames.Add(fileName);

                fileName = _hostingEnvironment.WebRootPath + fileName;

                using (FileStream fs = System.IO.File.Create(fileName))
                {
                    file.CopyTo(fs);
                    fs.Flush();
                }
            }

            return new ResultObject
            {
                state = "Success",
                resultObject = filenames
            };
        }

        [HttpPost("ifile")]
        public ResultObject UploadIFormFile(IFormFile file, String Code)
        {
            Console.WriteLine("IFormFile  Uploading...");
            Console.WriteLine("Code=" + Code);
            List<String> filenames = new List<string>();

            HttpRequest request = Request;
            Console.WriteLine("request.ContentType = " + request.ContentType);

            if (file == null)
            {
                Console.WriteLine("file==null");

                return new ResultObject
                {
                    state = "Fail",
                    resultObject = "file==null"
                };
            }

                var fileName = file.FileName;
                Console.WriteLine(fileName);

                fileName = $"/UploadFile/{fileName}";
                filenames.Add(fileName);

                fileName = _hostingEnvironment.WebRootPath + fileName;

                using (FileStream fs = System.IO.File.Create(fileName))
                {
                    file.CopyTo(fs);
                    fs.Flush();
                }
            

            return new ResultObject
            {
                state = "Success",
                resultObject = filenames
            };
        }

    }
}