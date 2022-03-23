using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.Controllers
{
    public class TestController : Controller
    {
    //public IActionResult Index()
        //{
        //    return View();
        //}

        //public FileResult Index()
        //{
        //    var fileByte = System.IO.File.ReadAllBytes("wwwroot/test.txt");
        //    const string fileName = "testFile.txt";
        //    return File(fileByte, MediaTypeNames.Text.Plain, fileName);
        //}

        public javascriptResult Index()
        {
            return new javascriptResult("alert('salam mehdi behroozi hasta");
        }
    }

    public class javascriptResult : ContentResult
    {
        public javascriptResult(string data)
        {
            Content = data;
            ContentType = "application/javascript";
        }
    }
}