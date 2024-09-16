using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        [HttpGet("/HelloWorld")]
        public IActionResult Index()
        {
            return View();
        }
        // 
        //GET: /HelloWorld/Welcome/ 
        //[HttpGet("{id}")]

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["message"] = "Hello "+name;
            ViewData["numTimes"] = numTimes;
            return View();
        }

    }//End hello world controller class
}//End namespace
