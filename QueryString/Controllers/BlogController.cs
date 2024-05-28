using Microsoft.AspNetCore.Mvc;

namespace QueryString.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            string name = HttpContext.Request.Query["name"].ToString();
            string family = HttpContext.Request.Query["family"].ToString();
            ViewBag.Name = name + " " + family;
            return View();
        }
        public IActionResult index2(string name, string family)
        {
            if(name==null || family == null)
            {
                ViewBag.Name = "مقداری وارد نشده است.";
                return View();
            }
            ViewBag.Name = name + " " + family;
            return View();
        }
        public IActionResult index3(int id)
        {
            ViewBag.id= id;
            return View();
        }

    }
}
