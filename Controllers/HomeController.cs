using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using APIProject.Models;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

namespace APIProject.Controllers
{
    public class HomeController : Controller
    {
        public string GetData()
        {
            HttpWebRequest request = WebRequest.CreateHttp("http://www.recipepuppy.com/api/");

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader rd = new StreamReader(response.GetResponseStream());

            string ApiText = rd.ReadToEnd();

            return ApiText;
        }

        public JToken ParseJsonString(string text)
        {
            JToken output = JToken.Parse(text);
            return output;
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
