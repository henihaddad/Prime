using System;
using System.Activities.Statements;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller    
    {
        public ActionResult Index()
        {
            return View();
            
        }
        [HttpPost]
        public ActionResult Result(PrimeGenerator p)
        {
            Console.WriteLine("yess"+p.N);
            p.LaunchCommandLineApp();
            return View(p);
        }
        public ActionResult Integrated()
        {
            return View();
        }
        public ActionResult Form()
        {
            return View();
        }
        
        [HttpGet]
        public ActionResult About(PrimeGenerator p)
        {
            Console.WriteLine(p.N);
           // p = new PrimeGenerator();
            p.N = 50;
            p.LaunchCommandLineApp();
            ViewBag.Message = "Your application description page.";
            //  Thread.Sleep(2000);
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}