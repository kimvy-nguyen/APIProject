using APIProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace APIProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Search()
        {
            return View();
        }



        public IActionResult Index()
        {
            ViewBag.text = GetData();
            return View();
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
