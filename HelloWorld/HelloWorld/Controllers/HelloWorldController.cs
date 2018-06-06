using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public string Welcome()
        {
            return "Welcome to our world";
        }

        public string Display(string Name)
        {
            return "Hi " + Name + " \nwelcome to my page" ;
        }

        public object Index()
        {
            ViewBag.Name = "Shohag";
            return View();
        }

        public ActionResult Sum(int a , int b)
        {
            int sum = a + b;
            ViewBag.Sum = sum;

            return View("Index");
        }

        public ViewResult Show()
        {
            List<string> Names = new List<string>();
            Names.Add("Shohag");
            Names.Add("Himo");
            Names.Add("Shohag");
            Names.Add("Himo");
            Names.Add("Shohag");
            Names.Add("Himo");
            ViewBag.Name = Names;
            return View();
        }
    }
}