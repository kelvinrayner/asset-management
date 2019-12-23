using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Client.Models;
using Microsoft.AspNetCore.Http;

namespace Client.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //var a = HttpContext.Session.GetInt32("id");
            //var b = HttpContext.Session.GetString("username");
            //var c = HttpContext.Session.GetInt32("user_id");
            //if (a != null && b != null && c != null)
            //{
            //    return RedirectToAction("Dashboard", "Index");
            //}
            //else
            //{
            //    return RedirectToAction("Login", "Index");
            //}
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
