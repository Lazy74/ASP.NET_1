using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP1.Controllers
{
    public class InController : Controller
    {
        // GET: In
        public ActionResult Input()
        {
            return View();
        }

        public ActionResult Write(string line)
        {
            
            var FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App_Data", "input.txt");
            System.IO.File.AppendAllText(FilePath, line + Environment.NewLine);

            return View("Input");
        }

        public ActionResult Output()
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App_Data", "input.txt");

            ViewBag.Content = System.IO.File.ReadAllLines(filePath);

            return View();
        }
    }
}