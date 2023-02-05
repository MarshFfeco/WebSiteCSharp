using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebSiteCSharp.Models;

namespace WebSiteCSharp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HomeModel hm = new HomeModel();

            hm.Nome = "Anderson Borba";
            hm.Email = "anderson22khg@gmail.com";

            return View(hm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}