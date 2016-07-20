using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
            //return HtmlEncoder.Default.Encode(
            //    "Hello "+ name + ", NumTimes is "+ numTimes
            //    );
            //return "This is the welcome action method ...";
        }
    }
}