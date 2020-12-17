using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }


        // GET: /HelloWorld/Welcome/
        public ActionResult Welcome(string name, int level = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.Level = level;
            return View();
        }

    }
}